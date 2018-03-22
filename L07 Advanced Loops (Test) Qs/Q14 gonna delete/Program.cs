using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_gonna_delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int count = 1;

            do
            {
                count *= size ;
                size--;
               
            } while (1 < size);

            Console.WriteLine(count);
        }
    }
}
