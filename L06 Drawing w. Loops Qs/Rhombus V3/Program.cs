using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int spaces = 1; spaces <= size-row; spaces++)
                {
                    Console.Write(' ');
                }
                for (int stars = 1; stars <= row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int brow = 1; brow <= size-1; brow++)
            {
                for (int spaces = 1; spaces <= brow-1; spaces++)
                {
                    Console.Write(' ');
                }
                for (int stars = 1; stars <= size-brow; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
