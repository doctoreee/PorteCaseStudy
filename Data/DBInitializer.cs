using BoxOptimizer.Models;
using System.Linq;

namespace BoxOptimizer.Data
{
    public static class DBInitializer
    {
        public static void Initialize(ShipmentContext context)
        {
            context.Database.EnsureCreated();

            if (context.Boxes.Any())
            {
                context.Boxes.RemoveRange(context.Boxes.ToArray<Boxes>());
                context.SaveChanges();
            }

            var boxes = new Boxes[]
            {
            new Boxes{BOX_ID = 123450, WEIGHT = 3},
            new Boxes{BOX_ID = 123461, WEIGHT = 8},
            new Boxes{BOX_ID = 123472, WEIGHT = 11},
            new Boxes{BOX_ID = 123483, WEIGHT = 3},
            new Boxes{BOX_ID = 123494, WEIGHT = 13}
            };

            foreach (Boxes b in boxes)
            {
                context.Boxes.Add(b);
            }
            context.SaveChanges();

            if (context.ShipmentParts.Any())
            {
                context.ShipmentParts.RemoveRange(context.ShipmentParts.ToArray<ShipmentParts>());
                context.SaveChanges();
            }
        }
    }
}