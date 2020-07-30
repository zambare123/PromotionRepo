using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.Entities
{
    public class PromotionEntity : BaseEntity
    {
        [Key]
        public int PromoId { get; set; }
        public string PromoNm { get; set; }
        public string PromoProductNm { get; set; }
        public double ProductPromoNumber { get; set; }
        public double PromoValue { get; set; }
        public string PromoType { get; set; }
    }
}
