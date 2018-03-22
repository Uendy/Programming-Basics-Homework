using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double number = 1;

            for (int i = 0; i <= size; i += 2)
            {
                number = Math.Pow(2, i);
                Console.WriteLine(number);
            }



        }
    }
}
