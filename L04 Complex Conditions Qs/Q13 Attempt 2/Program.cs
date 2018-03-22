using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Attempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (((x >= 0 && x <= 3 * n) && y >= 0 && y <= n) || ((y >= n && y <= 4 * n) && x >= n && x <= 2 * n))

            {
                if (((x > 0 && x < 3 * n) && y > 0 && y < n) || ((y > n && y < 4 * n) && x > n && x < 2 * n))
                {
                    Console.WriteLine("Inside");
                }
                else if (y == n && x > n && x < 2 * n)
                { Console.WriteLine("Inside"); }
                else
                { Console.WriteLine("Border"); }

            }
            else
            { Console.WriteLine("Outside"); }
        }
    }
}
