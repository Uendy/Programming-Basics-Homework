﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Drawing_w_Loops_Qs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 1;  col <= 10;  col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
