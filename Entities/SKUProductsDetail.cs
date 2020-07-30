using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.Entities
{
    class SKUProductsDetail: BaseEntity
    {
        [Key]
        public int SKUProductId { get; set; }

        public int SKUProductNm { get; set; }
    }


}
