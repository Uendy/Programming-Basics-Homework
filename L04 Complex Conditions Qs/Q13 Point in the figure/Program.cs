using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Point_in_the_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((y >= 0 && y <= 4 * h && x >= h && x <= 2 * h) || (x >= 0 && x <= 3 * h && y >= 0 && y <= h))
            {
                if ((y > 0 && y < 4 * h && x > h && x < 2 * h) || (x > 0 && x < 3 * h && y > 0 && y < h))
                {
                    Console.WriteLine("Inside");
                }
                else if (x > h && x < 2 * h && y == h)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Border");
                }
            }
            else
            {
                Console.WriteLine("Outside");
            }


        }
    }
}
