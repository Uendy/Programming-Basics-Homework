using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            double number = 1;
            //Console.WriteLine(number);

            for (int i = 0; i <= size; i++)
            {
                number = Math.Pow(2, i);
                Console.WriteLine(number);
            }
        }
    }
}
