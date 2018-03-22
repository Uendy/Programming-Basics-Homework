using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int Lsum = 0;
            int Rsum = 0;

            for (int i = 0; i < n; i++)
            {
                int Lnum = int.Parse(Console.ReadLine());
                Lsum += Lnum;
            }

            for (int i = 0; i < n; i++)
            {
                int Rnum = int.Parse(Console.ReadLine());
                Rsum += Rnum;
            }
            int diff = Math.Abs(Lsum - Rsum);

            if (Lsum == Rsum)
            { Console.WriteLine($"Yes, sum = {Rsum} "); }
            else
            { Console.WriteLine($"No, diff = {diff}"); }

        }
    }
}
