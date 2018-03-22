using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int area = int.Parse(Console.ReadLine());
            //double grapes2 = double.Parse(Console.ReadLine());
            //int winewant = int.Parse(Console.ReadLine());
            //int workers = int.Parse(Console.ReadLine());

            //double usable = area * 0.4;
            //var grapedensity = usable * grapes2;
            //var liter = grapedensity / 2.5;

            //if (liter > winewant)
            //{
            //    var leftover = liter - winewant;
            //    var reward = leftover / workers;
            //    Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(liter)} liters.");
            //    Console.WriteLine($"{Math.Truncate(leftover)} liters left -> {reward} liters per person.");
            //}
            //else if (liter < winewant)
            //{
            //    var under = winewant - liter;
            //    Console.WriteLine($"It will be a tough winter! More {Math.Truncate(under)} liters wine needed.");
            //}

            int area = int.Parse(Console.ReadLine());
            double grapes2 = double.Parse(Console.ReadLine());
            int winewant = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            if (area >= 10 && area <= 5000)
            {&&
                if (grapes2 >= 0.00 && grapes2 <= 10.00)
                {
                    if (winewant >= 10  winewant <= 600)
                    {
                        if (workers >= 1 && workers <= 20)
                        {
                            double usable = area * 0.4;
                            var grapedensity = usable * grapes2;
                            var liter = grapedensity / 2.5;

                            if (liter > winewant)
                            {
                                var leftover = liter - winewant;
                                var reward = leftover / workers;
                                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(liter)} liters.");
                                Console.WriteLine($"{leftover} liters left -> {Math.Truncate(reward)} liters per person.");
                            }
                            else if (liter < winewant)
                            {
                                var under = winewant - liter;
                                Console.WriteLine($"It will be a tough winter! More {Math.Truncate(under)} liters wine needed.");
                            }
                        }
                    }
                }


            }
        }
    }
}

