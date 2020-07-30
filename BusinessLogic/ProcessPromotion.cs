using SKUPromotions.DataAccess;
using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.BusinessLogic
{
    public class ProcessPromotion
    {
        private readonly IDataAccessService _dataAccessService; 
        public ProcessPromotion(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        /// <summary>
        /// this method apply promotion to the input products from cart
        /// </summary>
        /// <param name="inputLst"></param>
        public void ApplyPromotions(List<ProductsInputEntity> inputLst)
        {
            List<SKUProductsDetail> prdctPriceLst = _dataAccessService.GetProductPrice();
            List<PromotionEntity> promoDetailsLst = _dataAccessService.GetPromotions();

            //Check if List is empty or not
            if (inputLst != null && inputLst.Count > 0)
            {
                List<double> pricelst = new List<double>();
                double price = 0.0;
                for (int i = 0; i < inputLst.Count; i++)
                {
                    var input = inputLst[0];
                    double prdctVal = prdctPriceLst.Where(x => x.SKUProductNm == input.ProductName).Select(x => x.ProductPrice).FirstOrDefault();
                    var data = promoDetailsLst.Where(x => x.PromoProductNm == input.ProductName).FirstOrDefault();
                    if(input.NumberOfProducts > data.ProductPromoNumber)
                    {
                        price = data.PromoValue + (input.NumberOfProducts * prdctVal);
                    }
                    pricelst.Add(price);


                }
            }


        }
    }
}
