using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int Esum = 0;
            int Osum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Esum += num;
                }
                else
                {
                    Osum += num;
                }
            }

            if (Esum == Osum)
            { Console.WriteLine($"Yes, sum = {Esum}"); }
            else
            {
                int diff = Math.Abs(Osum - Esum);
                Console.WriteLine($"No, diff = {diff}");
            }
            
        }
    }
}
