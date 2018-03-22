using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var onestdashes = new string('-', (size -1) /2);
            var leftright = (size - 1) / 2;
            char star = '*';
            

            string topmostrow = onestdashes + star + onestdashes;
            Console.WriteLine(topmostrow);

            for (int toprow = 1; toprow <= (size+1)/2; toprow++)
            {
                var topdashes = new string('-', (size / 2) - toprow);
                var stuffing = new string('-', size - 2 * leftright - 2);

                string otherrows = topdashes + star + stuffing + star + topdashes;
                Console.WriteLine(otherrows);

            }
            
        }
    }
}
