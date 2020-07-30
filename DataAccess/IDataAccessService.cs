using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.DataAccess
{
    public interface IDataAccessService
    {
        List<SKUProductsDetail> GetProductPrice();
        List<PromotionEntity> GetPromotions();
    }
}
