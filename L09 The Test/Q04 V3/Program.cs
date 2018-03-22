using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int numbers = 0;
            int capitalLetters = 0;
            int lowerLetters = 0;
            int misc = 0;

            string numCount = null;
            string cLCount = null;
            string lLCount = null;
            string miscCount = null;

            for (int spin = 1; spin <= size; spin++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (symbol >= '0' && symbol <= '9')
                {
                    numbers += symbol;
                    numCount += symbol;
                }

                else if (symbol >= 'A' && symbol <= 'Z')
                {
                    capitalLetters += symbol;
                    cLCount += symbol;
                }
                else if (symbol >= 'a' && symbol <= 'z')
                {
                    lowerLetters += symbol;
                    lLCount += symbol;
                }
                else
                {
                    misc += symbol;
                    miscCount += symbol;
                }
            }

            if (numbers >= capitalLetters && numbers >= lowerLetters && numbers >= misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{numbers}");
                Console.WriteLine($"Combination of characters is:{numCount}");
            }
            else if (capitalLetters >= numbers && capitalLetters >= lowerLetters && capitalLetters >= misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{capitalLetters}");
                Console.WriteLine($"Combination of characters is:{cLCount}");
            }
            else if (lowerLetters >= numbers && lowerLetters >= capitalLetters && lowerLetters >= misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{lowerLetters}");
                Console.WriteLine($"Combination of characters is:{lLCount}");
            }
            else
            {
                Console.WriteLine($"Biggest ASCII sum is:{misc}");
                Console.WriteLine($"Combination of characters is:{miscCount}");
            }
        }
    }
}
