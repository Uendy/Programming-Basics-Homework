﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            if (food == "banana" || food == "apple" || food == "kiwi" || food == "cherry" || food == "lemon" || food == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (food == "tomato" || food == "cucumber" ||  food == "pepper" || food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }


            // to make it look cleaner do 
            //if (food == "banana" || 
            //    food == "apple" ||
            //    food == "kiwi" ||
            //    food == "cherry" ||
            //    food == "lemon" ||
            //    food == "grapes")

        }
    }
}
