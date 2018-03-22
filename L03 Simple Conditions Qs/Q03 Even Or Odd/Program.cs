using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());

            if (grade % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
