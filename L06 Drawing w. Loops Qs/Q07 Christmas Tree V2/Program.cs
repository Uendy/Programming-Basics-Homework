using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_Christmas_Tree_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size+1; row++)
            {
                for (int spaces = 1; spaces <= size+1-row; spaces++)
                {
                    Console.Write(" ");
                }

                for (int stars = 1; stars <= row-1; stars++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int stars = 1; stars <=row-1; stars++)
                {
                    Console.Write("*");
                }
                for (int spaces = 1; spaces <= size+1-row; spaces++)
                {
                    Console.Write(" ");
                }
               

                Console.WriteLine();
            }
        }
    }
}
