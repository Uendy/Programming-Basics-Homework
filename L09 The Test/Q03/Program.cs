using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            string arena = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            string itemLevel = Console.ReadLine().ToLower();

            double itemprice;

            if (itemLevel == "poor")
            {
                itemprice = 7000;

                if (arena == "nagrand" && day == "monday" || day == "wednesday" && arena == "nagrand")
                {
                    itemprice *= 0.95;
                }
                else if (arena == "gurubashi" && day == "tuesday" || day == "thursday" && arena == "gurubashi")
                {
                    itemprice *= 0.9;
                }
                else if (arena == "dire maul" && day == "friday" || day == "saturday" && arena == "dire maul")
                {
                    itemprice *= 0.93;
                }

                if (points >= itemprice)
                {
                    Console.WriteLine("Items bought: 5");
                    var leftover = points - itemprice;
                    Console.WriteLine($"Arena points left: {leftover}");
                    Console.WriteLine("Success!");
                }
                else
                {
                    double singleItem = itemprice / 5.0;

                    if (points >= singleItem)
                    {
                        if (points >= singleItem * 2)
                        {
                            if (points >= singleItem * 3)
                            {
                                if (points >= singleItem * 4)
                                {
                                    if (points < singleItem * 5)
                                    {
                                   
                                        Console.WriteLine("Items bought: 4");
                                        var diff = Math.Abs(singleItem * 4- points);
                                        Console.WriteLine($"Arena points left: {diff}");
                                        Console.WriteLine("Failure!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Items bought: 3");
                                    var diff = Math.Abs(singleItem * 3 -points);
                                    Console.WriteLine($"Arena points left: {diff}");
                                    Console.WriteLine("Failure!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Items bought: 2");
                                var diff = Math.Abs(singleItem * 2 - points);
                                Console.WriteLine($"Arena points left: {diff}");
                                Console.WriteLine("Failure!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Items bought: 1");
                            var diff = Math.Abs(singleItem - points);
                            Console.WriteLine($"Arena points left: {diff}");
                            Console.WriteLine("Failure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Items bought: 0");
                        Console.WriteLine($"Arena points left: {points}");
                        Console.WriteLine("Failure!");
                    }
                }
            }

            else if (itemLevel == "normal")
            {
                itemprice = 14000;

                if (arena == "nagrand" && day == "monday" || day == "wednesday" && arena == "nagrand")
                {
                    itemprice *= 0.95;
                }
                else if (arena == "gurubashi" && day == "tuesday" || day == "thursday" && arena == "gurubashi")
                {
                    itemprice *= 0.9;
                }
                else if (arena == "dire maul" && day == "friday" || day == "saturday" && arena == "dire maul")
                {
                    itemprice *= 0.93;
                }

                if (points >= itemprice)
                {
                    Console.WriteLine("Items bought: 5");
                    var leftover = points - itemprice;
                    Console.WriteLine($"Arena points left: {leftover}");
                    Console.WriteLine("Success!");
                }
                else
                {
                    double singleItem = itemprice / 5.0;

                    if (points >= singleItem)
                    {
                        if (points >= singleItem * 2)
                        {
                            if (points >= singleItem * 3)
                            {
                                if (points >= singleItem * 4)
                                {
                                    if (points < singleItem * 5)
                                    {

                                        Console.WriteLine("Items bought: 4");
                                        var diff = Math.Abs(singleItem * 4 - points);
                                        Console.WriteLine($"Arena points left: {diff}");
                                        Console.WriteLine("Failure!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Items bought: 3");
                                    var diff = Math.Abs(singleItem * 3 - points);
                                    Console.WriteLine($"Arena points left: {diff}");
                                    Console.WriteLine("Failure!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Items bought: 2");
                                var diff = Math.Abs(singleItem * 2 - points);
                                Console.WriteLine($"Arena points left: {diff}");
                                Console.WriteLine("Failure!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Items bought: 1");
                            var diff = Math.Abs(singleItem - points);
                            Console.WriteLine($"Arena points left: {diff}");
                            Console.WriteLine("Failure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Items bought: 0");
                        Console.WriteLine($"Arena points left: {points}");
                        Console.WriteLine("Failure!");
                    }
                }
            }

            else if (itemLevel == "legendary") // Legendary
            {
                itemprice = 21000;

                if (arena == "nagrand" && day == "monday" || day == "wednesday" && arena == "nagrand")
                {
                    itemprice *= 0.95;
                }
                else if (arena == "gurubashi" && day == "tuesday" || day == "thursday" && arena == "gurubashi")
                {
                    itemprice *= 0.9;
                }
                else if (arena == "dire maul" && day == "friday" || day == "saturday" && arena == "dire maul")
                {
                    itemprice *= 0.93;
                }

                if (points >= itemprice)
                {
                    Console.WriteLine("Items bought: 5");
                    var leftover = points - itemprice;
                    Console.WriteLine($"Arena points left: {leftover}");
                    Console.WriteLine("Success!");
                }
                else
                {
                    double singleItem = itemprice / 5.0;

                    if (points >= singleItem)
                    {
                        if (points >= singleItem * 2)
                        {
                            if (points >= singleItem * 3)
                            {
                                if (points >= singleItem * 4)
                                {
                                    if (points < singleItem * 5)
                                    {

                                        Console.WriteLine("Items bought: 4");
                                        var diff = Math.Abs(singleItem * 4 - points);
                                        Console.WriteLine($"Arena points left: {diff}");
                                        Console.WriteLine("Failure!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Items bought: 3");
                                    var diff = Math.Abs(singleItem * 3 - points);
                                    Console.WriteLine($"Arena points left: {diff}");
                                    Console.WriteLine("Failure!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Items bought: 2");
                                var diff = Math.Abs(singleItem * 2 - points);
                                Console.WriteLine($"Arena points left: {diff}");
                                Console.WriteLine("Failure!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Items bought: 1");
                            var diff = Math.Abs(singleItem - points);
                            Console.WriteLine($"Arena points left: {diff}");
                            Console.WriteLine("Failure!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Items bought: 0");
                        Console.WriteLine($"Arena points left: {points}");
                        Console.WriteLine("Failure!");
                    }
                }
            }
        }
    }
}