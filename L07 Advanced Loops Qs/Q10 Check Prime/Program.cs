using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int readnumber = int.Parse(Console.ReadLine());
            int increment = 2;


            if (readnumber <= 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }


            if (readnumber == 2)
            {
                Console.WriteLine("Prime");
                return;
            }

            do
            {
                if (readnumber % increment == 0) //notprime
                {
                    break;
                }
                else
                {
                    increment++;
                    if (increment >= readnumber)
                    {
                        Console.WriteLine("Prime");
                        return;
                    }
                }
            } while (readnumber % increment != 0);

            Console.WriteLine("Not Prime");
        }
    }
}
