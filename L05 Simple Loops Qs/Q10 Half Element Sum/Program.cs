using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Half_Element_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int others = 0;

            for (int i = 0; i < n-1; i++)
            {
               int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    others += max;
                    max = num;

                }
                else
                {
                    others += num;
                }
            }

            if (max == others)
            { Console.WriteLine($"Yes sum = {others}"); }
            else if (max != others)
            {
                int diff = Math.Abs(max - others);
                Console.WriteLine($"No diff = {diff}");
            }
        }
    }
}
