﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            // ??? HOW TO DO THE || in an if statement???

            if ((x1 <= x && x <= x2 && y1 = y) || (x1 <= x && x <= x2 && y = y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y1 <= y && y <= y2 && x1 = x) || (y1 <= y && y <= y2 && x2 = x))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
