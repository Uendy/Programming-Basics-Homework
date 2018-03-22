using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_GDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            while (second > 0)
            {
                int rem = first % second;
                first = second;
                second = rem;
            }
            Console.WriteLine(first);
        }
    }
}
