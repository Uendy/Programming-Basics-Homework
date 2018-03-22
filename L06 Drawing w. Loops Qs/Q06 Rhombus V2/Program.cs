using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_Rhombus_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            // the only difference is i did "* " instead of " *" which put a space before every line
            int size = int.Parse(Console.ReadLine());

            //top + middle:
            for (int row = 1; row <= size; row++)
            {
                for (int spaces = 1; spaces <= size-row; spaces++)
                {
                    Console.Write(" ");
                }

                for (int stars = 1; stars <= row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < size ; row++)
            {
                for (int spaces = 1; spaces <= row; spaces++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= size-row; stars++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
