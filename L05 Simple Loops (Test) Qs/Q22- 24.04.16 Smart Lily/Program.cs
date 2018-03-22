using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q22__24._04._16_Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
       
            int bdaycash = 0;
            int toys = 0;
            int totalcash = 0;

            for (int i = 1; i <= age; i++)
            {

                if (i % 2 == 0)
                {
                    bdaycash += i * 5;
                    bdaycash--;
                }
                else
                {
                    toys++;
                }

            }

            totalcash = toys * toyPrice;
            totalcash += bdaycash;

            var extra = Math.Abs(totalcash - washerPrice);

            if (totalcash >= washerPrice)
            { Console.WriteLine($"Yes! {extra:f2}"); }
            else
            { Console.WriteLine($"No! {extra:f2}"); }
            
        }
    }
}
