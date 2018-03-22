using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 0; i < size; i++)
            {
                sum *= size - i;
            }
            Console.WriteLine(sum);
        }
    }
}
