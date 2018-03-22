using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            // top and bottom
            var topstars = new string('*', size * 2);
            var spaces = new string(' ',size);

            var top = topstars + spaces + topstars;
            Console.WriteLine(top);

            //middle
            var middlestars = '*';
            var middleslashes = new string('/', size * 2 - 2);

            var middle = middlestars + middleslashes + middlestars + spaces + middlestars + middleslashes + middlestars;

            var nose = new string('|', size);
            var bridge = middlestars + middleslashes + middlestars + nose + middlestars + middleslashes + middlestars;

            for (int row = 1; row <= size-2; row++)
            {
                //super shit presmetka
                bool bridgerow = row == ((size -1) / 2);
                if (!bridgerow)
                {
                    Console.WriteLine(middle);
                }
                else
                {
                    Console.WriteLine(bridge);
                }
                
               
            }

            //bottom (same as top)
          
            Console.WriteLine(top);
        }
    }
}
