using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.Entities
{
    public class SKUProductsDetail: BaseEntity
    {
        [Key]
        public int SKUProductId { get; set; }

        public string SKUProductNm { get; set; }

        public double ProductPrice { get; set; }
    }


}
