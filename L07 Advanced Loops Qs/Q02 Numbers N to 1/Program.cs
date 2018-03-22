using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = size; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
