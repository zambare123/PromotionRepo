using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.DataAccess
{
    class AppDBContext : DbContext
    {
        public AppDBContext() : base("DBConnectionString")
        {

        }

        public DbSet<PromotionEntity> promotionEntities { get; set; }

        public DbSet<SKUProductsDetail> sKUProductsDetail { get; set; }
    }
}
