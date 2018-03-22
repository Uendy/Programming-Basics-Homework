using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            int ones = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int huns = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= ones; num1++)
            {
                if (num1 % 2 == 0)
                {
                    //Console.Write(num1);
                    continue;
                }
                else num1++;
                


                    for (int num2 = 1; num2 <= tens; num2++)
                    {
                        for (int i = 2; i <= Math.Sqrt(tens); i++)
                        {
                            if (tens % i == 0)
                            {
                                num2 = 2;
                                Console.Write(num2);
                                continue;
                            }
                            


                        }


                        for (int num3 = 1; num3 <= huns; num3++)
                        {
                            if (num3 % 2 == 0)
                            {
                                Console.WriteLine($"{num1}{num2}{num3}");
                                continue;
                            }
                           
                        }
                    }
                
            }
        }
    }
}