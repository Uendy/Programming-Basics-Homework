using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gрад / продукт coffee water beer sweets peanuts
            //Sofia 0.50 0.80 1.20 1.45 1.60
            //Plovdiv 0.40 0.70 1.15 1.30 1.50
            //Varna 0.45 0.70 1.10 1.35 1.55
            // Product, Town, Amount

            string product = Console.ReadLine();

            string town = Console.ReadLine();

            var sum = double.Parse(Console.ReadLine());
            
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    sum *= 0.4;
                }
                else if (product == "water")
                {
                    sum *= 0.7;
                }
                else if (product == "beer")
                {
                    sum *= 1.15;
                }
                else if (product == "sweets")
                {
                    sum *= 1.3;
                }
                else if (product == "peanuts")
                {
                    sum *= 1.5;
                }
                else
                {
                    Console.WriteLine("null");
                }

            }
            else if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    sum *= 0.5;
                }
                else if (product == "water")
                {
                    sum *= 0.8;
                }
                else if (product == "beer")
                {
                    sum *= 1.2;
                }
                else if (product == "sweets")
                {
                    sum *= 1.45;
                }
                else if (product == "peanuts")
                {
                    sum *= 1.6;
                }
                else
                {
                    Console.WriteLine("null");
                }

            }
            

            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    sum *= 0.45;
                }
                else if (product == "water")
                {
                    sum *= 0.7;
                }
                else if (product == "beer")
                {
                    sum *= 1.1;
                }
                else if (product == "sweets")
                {
                    sum *= 1.35;
                }
                else if (product == "peanuts")
                {
                    sum *= 1.55;
                }
                else
                {
                    Console.WriteLine("null");
                }

            }

            Console.WriteLine(sum);
            // prod1Intown1 = value * 0.5;
        }
    }
}
