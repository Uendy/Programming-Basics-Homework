using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_02._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int top = 0;
            int diff = 0;

            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int sum = num1 + num2;

                if (i < 2)
                {
                    top = sum;
                }
                if (i >= 2)
                {
                    if (sum != top)
                    {
                        diff = Math.Abs(top - sum);
                        top = sum;
                    }

                }

            }

            if (diff == 0)
            {
                Console.WriteLine($"Yes, value = {top}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {diff}");
            }
        }
    }
}
