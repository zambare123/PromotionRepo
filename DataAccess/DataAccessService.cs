using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.DataAccess
{
    public class DataAccessService : AppDBContext, IDataAccessService
    {
        private readonly AppDBContext _context;
        public DataAccessService(AppDBContext context)
        {
            _context = context;
        }
        public DataAccessService()
        {
            _context = new AppDBContext();
        }


        public List<SKUProductsDetail> GetProductPrice()
        {
            return _context.sKUProductsDetail.ToList();
        }

        public List<PromotionEntity> GetPromotions()
        {
            return _context.promotionEntities.ToList();
        }

    }
}
