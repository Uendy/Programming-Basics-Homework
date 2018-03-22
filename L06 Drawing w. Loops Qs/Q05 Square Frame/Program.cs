using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            //My Way:
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.Write("+");
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" +");
                }
                else
                {
                    Console.Write("|");
                    for (int col = 1; col <= n - 2; col++)
                    {
                        Console.Write(" -");
                    }
                    Console.WriteLine(" |");
                }

                
            }
        }
    }
}
