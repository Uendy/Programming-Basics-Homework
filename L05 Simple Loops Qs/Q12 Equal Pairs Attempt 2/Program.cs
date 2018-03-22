using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_Equal_Pairs_Attempt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousSum = 0;
            int currentSum = 0;
            int maxdiff = 0;


            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                currentSum = number1 + number2;

                if (i != 0)
                {
                    if (previousSum != currentSum)
                    {
                        int currentDif = Math.Abs(previousSum - currentSum);
                        if (currentDif > maxdiff)
                        {
                            maxdiff = currentDif;
                        }
                    }
                    
                }

                previousSum = currentSum;
            }
            if (maxdiff == 0)
            {
                Console.WriteLine($"Yes, value = {previousSum}");
            }
            else
            {
                Console.WriteLine($"No, value = {maxdiff}");
            }



        }
    }
}
