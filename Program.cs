using SKUPromotions.BusinessLogic;
using SKUPromotions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUPromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessPromotion prcssPromoObj = new ProcessPromotion();
            List<ProductsInputEntity> InputObjLst = new List<ProductsInputEntity>();
            string IsContinue = string.Empty;
            do
            {
                ProductsInputEntity singleObj = new ProductsInputEntity();
                Console.WriteLine("Please enter Product name: ");
                singleObj.ProductName = Console.ReadLine();
                Console.WriteLine("Please enter Product Number: ");
                singleObj.NumberOfProducts = Convert.ToInt32(Console.ReadLine());
                InputObjLst.Add(singleObj);
                Console.WriteLine("do you Want to Conitunue(y/n) : ");
                IsContinue = Console.ReadLine();
            }
            while (IsContinue == "y");

            prcssPromoObj.ApplyPromotions(InputObjLst);
        }
    }
}
