using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21__26._03._16_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pt = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 1 && num <= 1000)
                {
                    pt++;

                    if (num % 2.0 == 0)
                    { p1++; }
                    if (num % 3.0 == 0)
                    { p2++; }
                    if (num % 4.0 == 0)
                    { p3++; }
                }

            }

            double fp1 = ((p1*1.0 / pt) * 100);
            double fp2 = ((p2*1.0 / pt) * 100);
            double fp3 = ((p3*1.0 / pt) * 100);

            double tfp1 = Math.Round(fp1, 2);
            double tfp2 = Math.Round(fp2, 2);
            double tfp3 = Math.Round(fp3, 2);
            //d.ToString("F") to get the last 0s!
            Console.WriteLine(tfp1.ToString("F2") + "%");
            Console.WriteLine(tfp2.ToString("F2") + "%");
            Console.WriteLine(tfp3.ToString("F2") + "%");

        }
    }
}
