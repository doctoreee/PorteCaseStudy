using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BoxOptimizer.Models
{
    public class Boxes
    {
        [Key]
        [DisplayName("BOX ID")]
        public int BOX_ID { get; set; }

        public int WEIGHT { get; set; }
        
        [DisplayName("PART COUNT")]
        public int PART_COUNT { get; set; }

        public ICollection<ShipmentParts> ShipmentParts { get; set; }
    }
}