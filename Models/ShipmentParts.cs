using System.ComponentModel;

namespace BoxOptimizer.Models
{
    public class ShipmentParts
    {
        [DisplayName("BOX ID")]
        public int BOX_ID { get; set; }

        [DisplayName("PART NUMBER")]
        public int PART_NUMBER { get; set; }

        [DisplayName("PART WEIGHT")]
        public int PART_WEIGHT { get; set; }

        [DisplayName("PART COST")]
        public int PART_COST { get; set; }
    }
}