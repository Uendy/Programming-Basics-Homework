using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string right = "//";
            string left = "\\\\";

            //top row 
            var topdots = new string('.', size + 1);
            var topborder = new string('_', size * 2 + 1);

            string toprow = topdots + topborder + topdots;
            Console.WriteLine(toprow);
        

            // uprows (between top and middle)

            for (int uprows = 0; uprows < size; uprows++)
            {
                var mupdots = size - uprows;
                var updots = new string('.', mupdots);
                
                var updashes = new string ('_',toprow.Length - 2 * mupdots - 4);

                string uppperrows = updots + right + updashes + left + updots;

                Console.WriteLine(uppperrows);

            }

            // middle bit :
            
            var middledashes = new string('_', (toprow.Length - 9) / 2);
            string stop = "STOP!";
            string middlebit = right + middledashes + stop + middledashes + left;

            Console.WriteLine(middlebit);

            //bottom bit :
            for (int bottrow = 0; bottrow < size; bottrow++)
            {
                
                var botdots = new string('.', bottrow);
                var botdashes = new string('_', toprow.Length - 4 - (2 * bottrow));

                string bottom = botdots + left + botdashes + right + botdots;

                Console.WriteLine(bottom);
            }

        }
    }
}
