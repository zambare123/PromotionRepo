using System;

namespace SKUPromotions.Entities
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public string MachineNm { get; set; }
    }
}