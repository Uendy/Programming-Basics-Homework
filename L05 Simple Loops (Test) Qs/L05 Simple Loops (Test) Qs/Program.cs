using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Simple_Loops__Test__Qs
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
            int p4 = 0;
            int p5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                pt++;

                {
                    if (num >= 1 && num < 200)
                    { p1++; }

                    else if (num >= 200 && num <= 399)
                    { p2++; }

                    else if (num >= 400 && num <= 599)
                    { p3++; }

                    else if (num >= 600 && num <= 799)
                    { p4++; }

                    else if (num >= 800 && num <= 1000)
                    { p5++; }
                }
            }

            double fp1 = (p1 / (pt*1.0)) * 100;
            double fp2 = (p2 / (pt*1.0)) * 100;
            double fp3 = (p3 / (pt*1.0)) * 100;
            double fp4 = (p4 / (pt*1.0)) * 100;
            double fp5 = (p5 / (pt*1.0)) * 100;

            Console.WriteLine(Math.Round(fp1,2) + "%");
            Console.WriteLine(Math.Round(fp2, 2) + "%");
            Console.WriteLine(Math.Round(fp3, 2) + "%");
            Console.WriteLine(Math.Round(fp4, 2) + "%");
            Console.WriteLine(Math.Round(fp5, 2) + "%");

        }
    }
}
