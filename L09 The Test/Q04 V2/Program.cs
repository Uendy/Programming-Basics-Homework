﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool prime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                { prime = false;
                    break;
                }

            }
            if (prime == true)
            { Console.WriteLine("Prime"); }
            else
            { Console.WriteLine("Not prime"); }
        }
    }
}
