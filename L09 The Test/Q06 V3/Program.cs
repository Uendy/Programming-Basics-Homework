using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ones = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int huns = int.Parse(Console.ReadLine());

            int first;
            int second;
            int third;

            for (int num1 = 2; num1 <= ones; num1++)
            {

                if (num1 % 2 == 0)
                {
                    first = num1;
                    for (int num2 = 2; num2 <= tens; num2++)
                    {
                        if (num2 == 1 || num2 == 4 || num2 == 6 || num2 == 8 || num2 == 9)
                        { continue; }
                        else // prime
                        {
                            second = num2;

                            for (int num3 = 1; num3 <= huns; num3++)
                            {
                                if (num3 % 2 == 0)
                                {
                                    third = num3;
                                    Console.WriteLine($"{first} {second} {third}");

                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        }

                    }
                
                else
                {
                    continue;
                }
            }
        }
    }
}
