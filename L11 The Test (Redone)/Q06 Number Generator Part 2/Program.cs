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

            int hundreds = huns * 100;
            int tens = tenz * 10;

            int startingNumber = hundreds + tens + ones;

            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());


            var reached = false;

            for (int i = startingNumber; i >= 111; i--)
            {
                if (i % 3 == 0)
                {
                    specialNumber += 5;
                }
                else if (i % 10 == 5)
                {
                    specialNumber -= 2;
                }
                else if (i % 2 == 0)
                {
                    specialNumber *= 2;
                }

                if (specialNumber >= controlNumber)
                {
                    reached = true;
                    break;
                }
            }

            if (reached)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
            }
            else
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }
        }

    }
}
