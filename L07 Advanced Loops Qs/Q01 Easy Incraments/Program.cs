using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01_Easy_Incraments
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <=  size; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
