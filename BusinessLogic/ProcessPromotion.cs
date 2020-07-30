using SKUPromotions.DataAccess;
using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions.BusinessLogic
{
    public class ProcessPromotion
    {
        private readonly IDataAccessService _dataAccessService;
        public ProcessPromotion()
        {
            _dataAccessService = new DataAccessService();
        }
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
                Dictionary<string, double> pricelst = new Dictionary<string, double>();
                double price = 0.0;
                for (int i = 0; i < inputLst.Count; i++)
                {
                    var input = inputLst[0];
                    double prdctVal = prdctPriceLst.Where(x => x.SKUProductNm == input.ProductName).Select(x => x.ProductPrice).FirstOrDefault();
                    var singlepromo = promoDetailsLst.Where(x => x.PromoProductNm == input.ProductName).FirstOrDefault();
                    if (singlepromo.PromoType == "Number")
                    {
                        if (input.NumberOfProducts > singlepromo.ProductPromoNumber)
                        {
                            price = singlepromo.PromoValue + (input.NumberOfProducts * prdctVal);
                        }
                        pricelst.Add(input.ProductName, price);
                    }

                    else if (singlepromo.PromoType == "Perc")
                    {
                        //applying percentage on one product and adin remaining products with actual value.
                        if (input.NumberOfProducts == 1)
                        {
                            price = (prdctVal - (singlepromo.PromoValue * prdctVal) / 100);
                            pricelst.Add(input.ProductName, price);
                        }
                        else if (input.NumberOfProducts > 1)
                        {
                            price = (prdctVal - (singlepromo.PromoValue * prdctVal) / 100) + prdctVal * (input.NumberOfProducts - 1);
                            pricelst.Add(input.ProductName, price);
                        }
                    }
                    else if (singlepromo.PromoType == "Combination")
                    {


                    }


                    foreach (var item in pricelst)
                    {
                        Console.WriteLine("Price of product " + item.Key + " = " + item.Value);
                    }
                    Console.WriteLine("Total price is : " + pricelst.Sum(x => x.Value));

                }
            }


        }
    }
}
