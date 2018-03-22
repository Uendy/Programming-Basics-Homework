using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Attempt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int horizontal = int.Parse(Console.ReadLine());
            int vertical = int.Parse(Console.ReadLine());
            // each if is a seperate rectangle





            if (horizontal < 0 || vertical < 0)
            {
                Console.WriteLine("outside");
            }
            else if (horizontal == 0 && vertical == length)
            {
                Console.WriteLine("border");
            }
            else if ((vertical == length) && horizontal == length || horizontal == 2 * length || horizontal == 3 * length)
            {
                Console.WriteLine("border");
            }
            else if ((vertical < length) && horizontal < 3 * length)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

            if (horizontal > length && horizontal < 2 * length)
            {
                if (horizontal == length || horizontal == 2 * length && vertical == length || vertical == 2 * length || vertical == 3 * length || vertical == 4 * length)
                {
                    Console.WriteLine("border");
                }
                else if (horizontal > length && horizontal < 2 * length && vertical > length || vertical < 4 * length)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}
