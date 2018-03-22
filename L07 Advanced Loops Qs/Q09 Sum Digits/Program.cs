using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sofar = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int cunt = 0;
                cunt = number[i];
                sofar += cunt - '0';
            }
            Console.WriteLine(sofar);
        }
    }
}
