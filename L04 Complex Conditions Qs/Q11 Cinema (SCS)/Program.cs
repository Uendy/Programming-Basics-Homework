using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Cinema__SCS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();

            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            double area = row * column;

            switch (projection)
            {
                case "Premiere":
                    area *= 12;
                    break;

                case "Normal":
                    area *= 7.50;
                    break;

                case "Discount":
                    area *= 5.00;
                    break;
            }
            Console.WriteLine($"{area:f2} leva");
        }
    }
}
