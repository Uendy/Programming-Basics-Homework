using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = +100000;
            double OddMax = -100000;
            double EvenSum = 0;
            double EvenMin = +100000;
            double EvenMax = -100000;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    OddSum += num;

                    if (num <= OddMin)
                    {
                        OddMin = num;
                    }
                    if (num >= OddMax)
                    {
                        OddMax = num;
                    }
                    


                }

                else if (i % 2 == 0)
                {
                    EvenSum += num;

                    if (num <= EvenMin)
                    {
                        EvenMin = num;
                    }
                    if (num >= EvenMax)
                    {
                        EvenMax = num;
                    }
                   
                }

            }
            Console.WriteLine($"OddSum = {OddSum}");

            if (OddMin == +1000000|| n == 0)
            { Console.WriteLine("OddMin = No"); }
            else
            { Console.WriteLine($"OddMin = {OddMin}"); }
            if (OddMax == -1000000 || n == 0)
            {Console.WriteLine("OddMax = No");}
            else
            { Console.WriteLine($"OddMax = {OddMax}"); }


            Console.WriteLine($"EvenSum = {EvenSum}");

            if (EvenMin == +100000 || n == 0)
            { Console.WriteLine("EvenMin = No");}
            else
            { Console.WriteLine($"EvenMin = {EvenMin}"); }
            if (EvenMax == -100000 || n ==0)
            {Console.WriteLine("EvenMax = No"); }
            else
            { Console.WriteLine($"EvenMax = {EvenMax}"); }

        }
    }
}

