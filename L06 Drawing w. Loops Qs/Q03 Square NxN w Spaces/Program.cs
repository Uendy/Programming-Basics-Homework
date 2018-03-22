using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Square_NxN_w_Spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // if you dont want the last C.WL() of an empty space

            // for (row)
            //{
            //for (int col = 1; col < n-1; col++)
            //{
            //    Console.WriteLine("* ");    
            //}
            //Console.WriteLine("*");
            //}       This way the empty space is the final star to complete it
        }
    }
}
