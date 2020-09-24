using System.Threading.Tasks;
using BoxOptimizer.Data;
using BoxOptimizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace BoxOptimizer.Controllers
{
    public class BoxesController : Controller
    {
        private readonly ShipmentContext _context;
        private const int MinimumParts = 2;
        private const int BasePrice = 50;
        private const int PartPrice = 7;


        public BoxesController(ShipmentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Boxes.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SplitBoxesToParts()
        {
            var tempCollection = await _context.Boxes.ToListAsync();
            var partCount = MinimumParts;

            while (tempCollection.Any<Boxes>())
            {
                var collection = tempCollection.OrderBy(x => x.WEIGHT).ThenBy(n => n.BOX_ID);
                var box = FindBestByPrice(collection, partCount);
                if (ModelState.IsValid)
                {
                    try
                    {
                        if (box.PART_COUNT > 0)
                        {

                            _context.Update(box);
                            await _context.SaveChangesAsync();

                            partCount++;
                        }
                        
                        tempCollection.Remove(box);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        throw;
                    }
                }

            }

            return View(("/Views/Boxes/Index.cshtml"), await _context.Boxes.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateParts()
        {
            SplitBoxToParts();
            await _context.SaveChangesAsync();
            return View(("/Views/Boxes/Index.cshtml"), await _context.Boxes.ToListAsync());
        }

        private Boxes FindBestByPrice(IOrderedEnumerable<Boxes> boxes, int partCount)
        {
            List<TempPartition> partitions = new List<TempPartition>();
            foreach (var box in boxes)
            {
                partitions.Add(new TempPartition(box, partCount));
            }

            var partition = partitions.OrderBy(x => x.Price).FirstOrDefault();
            partition?.Box?.ShipmentParts?.Clear();
            return partition?.Box;
        }

        private void SplitBoxToParts()
        {
            foreach (var item in _context.Boxes)
            {
                if (item.PART_COUNT > 0)
                {
                    item.ShipmentParts = new List<ShipmentParts>();
                    var mod = item.WEIGHT % item.PART_COUNT;
                    var partWeight = (item.WEIGHT - mod) / item.PART_COUNT;
                    for (int i = 0; i < item.PART_COUNT; i++)
                    {
                        ShipmentParts part = new ShipmentParts();
                        part.BOX_ID = item.BOX_ID;
                        part.PART_COST = 0;
                        part.PART_NUMBER = i + 1;
                        if (mod != 0)
                        {
                            part.PART_WEIGHT = partWeight + 1;
                            mod--;
                        }
                        else
                        {
                            part.PART_WEIGHT = partWeight;
                        }
                        part.PART_COST = CalculatePrice(part.PART_WEIGHT);
                        item.ShipmentParts.Add(part);
                        _context.Update(item);
                    }
                }
            }

        }

        private int CalculatePrice(int weight)
        {
            return BasePrice + (weight * PartPrice);
        }

        private class TempPartition
        {
            public Boxes Box;
            int PartCount = 0;
            public int Price = 0;

            public TempPartition(Boxes box, int partCount)
            {
                Box = box;
                Box.ShipmentParts = new List<ShipmentParts>();
                PartCount = partCount;
                SplitBoxToParts();
                if (Box.ShipmentParts.Any())
                {
                    Box.PART_COUNT = Box.ShipmentParts.Count;
                    CalculatePrice();
                }
                else
                {
                    Box.PART_COUNT = 0;
                }
            }

            private void SplitBoxToParts()
            {
                var mod = Box.WEIGHT % PartCount;
                if (mod == Box.WEIGHT)
                {
                    return;
                }

                var partWeight = (Box.WEIGHT - mod) / PartCount;
                for (int i = 0; i < PartCount; i++)
                {
                    ShipmentParts part = new ShipmentParts();
                    part.BOX_ID = Box.BOX_ID;
                    part.PART_COST = 0;
                    part.PART_NUMBER = i + 1;
                    if (mod != 0)
                    {
                        part.PART_WEIGHT = partWeight + 1;
                        mod--;
                    }
                    else
                    {
                        part.PART_WEIGHT = partWeight;
                    }
                    Box.ShipmentParts.Add(part);
                }
            }

            private void CalculatePrice()
            {
                foreach (var item in Box.ShipmentParts)
                {
                    Price += BasePrice + (item.PART_WEIGHT * PartPrice);
                }
            }
        }
    }
}