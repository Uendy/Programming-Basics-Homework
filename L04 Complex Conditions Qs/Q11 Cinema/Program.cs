using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();

            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            double area = row * column;

           
            if (projection == "Premiere")
            {
                area *= 12;
            }
            else if (projection == "Normal")
            {
                area *= 7.5;
            }
            else if (projection == "Discount")
            {
                area *= 5;
            }
            Console.WriteLine($"{area:f2} leva");
        }
    }
}
