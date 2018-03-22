using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_Grocery_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToUpper();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    sum = 2.50 * quantity;
                }
                else if (fruit == "apple")
                {
                    sum = 1.20 * quantity;
                }
                else if (fruit == "orange")
                {
                    sum = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    sum = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    sum = 2.70 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    sum = 5.50 * quantity;
                }
                else if (fruit == "grapes")
                {
                    sum = 3.85 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(sum,2));
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    sum = 2.70 * quantity;
                }
                else if (fruit == "apple")
                {
                    sum = 1.25 * quantity;
                }
                else if (fruit == "orange")
                {
                    sum = 0.90 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    sum = 1.60 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    sum = 3.00 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    sum = 5.60 * quantity;
                }
                else if (fruit == "grapes")
                {
                    sum = 4.20 * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(sum, 2));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
