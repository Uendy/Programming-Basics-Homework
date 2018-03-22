using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int huns = int.Parse(Console.ReadLine());
            int tenz = int.Parse(Console.ReadLine());
            int ones = int.Parse(Console.ReadLine());

            
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int i = huns; i >= 1; i--)
            {
                for (int j = tenz; j >= 1; j--)
                {
                    for (int k = ones; k >= ones; k--)
                    {
                        int number = i * 100 + j * 10 + k;

                        if (number % 3 == 0)
                        { specialNumber += 5; }
                        else if (number  % 10 == 5)
                        { specialNumber -= 2; }
                        else if (number  % 2 == 0)
                        { specialNumber *= 2; }

                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }

                    }

                }

            }
            
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
        }

    }
}