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
            string IsContinue = string.Empty;
            do
            {
                Console.WriteLine("Please enter Product name: ");
                string productvalue = Console.ReadLine();
                Console.WriteLine("Please enter Product Number: ");
                int productnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("do you Want to Conitunue(y/n) : ");
                IsContinue = Console.ReadLine();
            }
            while (IsContinue == "y");
        }
    }
}
