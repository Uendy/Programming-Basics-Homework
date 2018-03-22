using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Martins_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Martins Way:
            int size = int.Parse(Console.ReadLine());
            Console.Write('+');
            for (int i = 1; i <= size - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

            for (int i = 1; i <= size - 2; i++)
            {
                Console.Write('|');
                for (int j = 1; j <= size - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            Console.Write('+');
            for (int k = 0; k < size - 2; k++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
