using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09_AT2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 9; row++)
            {
                Console.Write($"Row: {row}");
                for (int coll = 1; coll <= 10; coll++)
                {
                    Console.Write(coll);
                }
                Console.WriteLine();
            }
          
        }
    }
}
