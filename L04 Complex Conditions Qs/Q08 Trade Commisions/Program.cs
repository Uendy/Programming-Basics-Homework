using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Trade_Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;

            if (town == "Sofia")
            {
                if (sales > 10000)
                {
                    commision = sales * 0.12;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commision = sales * 0.08;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commision = sales * 0.07;
                }
                else if (sales <= 500 && sales >= 0)
                {
                    commision = sales * 0.05;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(commision,2));
            }
            else if (town == "Varna")
            {
                if (sales > 10000)
                {
                    commision = sales * 0.13;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commision = sales * 0.1;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commision = sales * 0.075;
                }
                else if (sales <= 500 && sales >= 0)
                {
                    commision = sales * 0.045;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(commision, 2));
            }
            else if (town == "Plovdiv")
            {
                if (sales > 10000)
                {
                    commision = sales * 0.145;
                }
                else if (sales <= 10000 && sales > 1000)
                {
                    commision = sales * 0.12;
                }
                else if (sales <= 1000 && sales > 500)
                {
                    commision = sales * 0.08;
                }
                else if (sales <= 500 && sales >= 0)
                {
                    commision = sales * 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(Math.Round(commision, 2));
            }
            else
            { Console.WriteLine("error"); }

        }
    }
}
