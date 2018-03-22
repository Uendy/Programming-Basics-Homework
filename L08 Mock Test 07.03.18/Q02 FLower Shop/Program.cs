using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_FLower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double mags = double.Parse(Console.ReadLine());
            double totalMags = mags * 3.25;

            double zombies = double.Parse(Console.ReadLine());
            double totalZombies = zombies * 4.0;

            double roses = double.Parse(Console.ReadLine());
            double totalRoses = roses * 3.50;

            double cactus = double.Parse(Console.ReadLine());
            double totalCactus = cactus * 8;

            double beforetax = totalMags + totalZombies + totalRoses + totalCactus;
            double tax = beforetax / 20.0;
            double aftertax = beforetax - tax;

            double present = double.Parse(Console.ReadLine());


            if (aftertax >= present)
            {
                var difference = Math.Floor(aftertax - present);
                Console.WriteLine($"She is left with {difference} leva.");
            }
            else
            {
                var difference = Math.Abs(aftertax - present);
                difference = Math.Ceiling(difference);
                Console.WriteLine($"She will have to borrow {difference} leva.");
            }

        }
    }
}
