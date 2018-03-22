using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Attempt_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int horizontal = int.Parse(Console.ReadLine());
            int vertical = int.Parse(Console.ReadLine());

            if (vertical < length)
            {
                if (horizontal < 0 || vertical < 0)
                {
                    Console.WriteLine("outside");
                }
                else if (horizontal > 0 && horizontal < 3 * length)
                {
                    Console.WriteLine("inside");
                }
                else if (horizontal == 0 || horizontal == length || horizontal == 2 * length || horizontal == 3 * length)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
            else if (vertical == length || vertical == 0)
            {
                if (horizontal == 0 || horizontal == length || horizontal == 2 * length || horizontal == 3 * length)
                {
                    Console.WriteLine("border");
                }
            }

            if (vertical > length && vertical < 4 * length)
            {
                if (horizontal > length && horizontal < 2 * length)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
            else if (vertical == length && vertical <= 4 * length)
            {
                if (vertical == length || vertical == 2 * length || vertical == 3 * length || vertical == 4 * length)
                {
                    if (horizontal == length || horizontal == 2 * length)
                    {
                        Console.WriteLine("border");
                    }
                }
            }
            else
            {
                Console.WriteLine("outside");
            }           
        }
    }
}
