using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_Fibbonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            if (size <= 1)
            { Console.WriteLine(1); }

            int first = 1;
            int second = 1;

            for (int i = 2; i <= size; i++)
            {
                if (i % 2 == 0) //even ones
                {
                    first = first + second;
                    if (size == i)
                    { Console.WriteLine(first); }
                }

                else // odd
                {
                    second = first + second;
                    if (size == i)
                    { Console.WriteLine(second); }
                }
            }

        }
    }
}
