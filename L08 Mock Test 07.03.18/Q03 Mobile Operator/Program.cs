using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string years = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price;

            if (years == "one")
            {
                if (type == "Small")
                {
                    price =+ 9.98;
                }
                else if (type == "Medium")
                {
                    price =+ 18.99;
                }
                else if (type == "Large")
                {
                    price =+ 25.98;
                }
                else // XL
                {
                    price =+ 35.99;
                }

                if (internet == "yes")
                {
                    if (price < 10.00)
                    { price += 5.50; }
                    else if (price < 30.00)
                    { price += 4.35; }
                    else
                    { price += 3.85; }
                }

                price *= months;
                price = Math.Round(price, 2);
                Console.WriteLine($"{price:f2} lv.");
            }

            else//2
            {
                if (type == "Small")
                {
                    price =+ 8.58;
                }
                else if (type == "Middle")
                {
                    price =+ 17.09;
                }
                else if (type == "Large")
                {
                    price =+ 23.59;
                }
                else // XL
                {
                    price =+ 31.79;
                }

                if (internet == "yes")
                {
                    if (price < 10.00)
                    { price += 5.50; }
                    else if (price < 30.00)
                    { price += 4.35; }
                    else
                    { price += 3.85; }
                }

                price *= months;
                double tax = price / 100 * 3.75;
                price = price - tax;
                price = Math.Round(price, 2);
                Console.WriteLine($"{price:f2} lv.");
            }
        }
    }
}
