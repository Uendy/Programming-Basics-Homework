using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int num = 1;

            //way 1 : For Cycle
            //for (int i = num; num <= size; i++)
            //{
            //    Console.WriteLine(num);

            //    num = num * 2 + 1;
            //}

            //Way 2 : While Loop
            while (num <= size)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
