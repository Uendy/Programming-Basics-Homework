using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            int count = 1;

            for (int row = 1; readNumber >= count; row++)
            {
                Console.Write($"{count} ");
                count++;
                Console.WriteLine();

                for (int coll = 1; coll <= row; coll++)
                {
                    if (readNumber <= count - 1)
                    { return; } 

                    Console.Write($"{count} ");
                    count++;

                    
                }

            }

        }
    }
}
