using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char structure = '|';
            var bottomfill = new string('*', size - 2);

            string bottom = structure + bottomfill + structure;

            //top

            for (int row = 1; row <= (size + 1) / 2; row++)
            {
                for (int dashes = 1; dashes <= ((size + 1) / 2 - row); dashes++)
                {
                    Console.Write('-');
                }

                if (size % 2 == 0)
                {
                    for (int stars = 1; stars <= row * 2; stars++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    for (int stars = 1; stars <= (row*2)-1; stars++)
                    {
                        Console.Write('*');
                    }
                }

                for (int dashes = 1; dashes <= ((size + 1) / 2 - row); dashes++)
                {
                    Console.Write('-');
                }

                Console.WriteLine();
            }



            //bottom
            for (int Osnova = 1; Osnova <= size/2; Osnova++)
            {
                Console.WriteLine(bottom);
            }
        }
    }
}

