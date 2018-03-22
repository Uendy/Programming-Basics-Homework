using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var stars = new string('*', size - 2);
            var dashes = new string('-', size - 2);
            char right = '/';
            char left = '\\';
            char space = ' ';
            var middle = new string(' ', (2 * size - 1) / 2);
            char body = '@';

            string topodd = stars + left + space + right + stars;
            string topeven = dashes + left + space + right + dashes;

            string mid = middle + body;

            string botodd = stars + right + space + left + stars;
            string boteven = dashes + right + space + left + dashes;


            for (int row = 1; row <= 2 * (size-2); row++)
            {
                if (row <= size - 2) //top side
                {
                    if (row % 2 != 0)
                    {
                        Console.WriteLine(topodd);
                    }
                    else
                    {
                        Console.WriteLine(topeven);
                    }
                }
                if (row == size - 1) //middle
                {
                    Console.WriteLine(mid);
                }
                if (row > size - 2) //bottom side
                {
                    if (row % 2 != 0)
                    {
                        Console.WriteLine(boteven);
                    }
                    else
                    {
                        Console.WriteLine(botodd);
                    }
                }
            }

        }
    }
}
