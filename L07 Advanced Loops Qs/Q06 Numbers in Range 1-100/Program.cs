using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_Numbers_in_Range_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            while (number<1 || number > 100)
            {
                Console.WriteLine("Enter a number in the range[1...100]:");
                Console.WriteLine("Invalid number!");
                int num = int.Parse(Console.ReadLine());
                number = num;
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
