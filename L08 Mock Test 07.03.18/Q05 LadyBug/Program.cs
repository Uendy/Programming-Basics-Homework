using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var eyespaces = new string(' ', size - 2);
            var eye = new string('@', 1);
            Console.WriteLine(eyespaces + eye + "   " + eye);

            var lineTwoSpaces = new string(' ', size - 1);
            string lineTwo = ("\\_/");
            Console.WriteLine(lineTwoSpaces + lineTwo);

            string lineThree = ("/ \\");
            Console.WriteLine(lineTwoSpaces + lineThree);

            string lineFour = ("|_|");
            Console.WriteLine(lineTwoSpaces + lineFour);

            //body (pyramind shape)

            for (int row = 1; row <= size; row++)
            {
                var bodyspace = new string(' ', size - row);
                var innerspaces = new string(' ', row-1);
                Console.WriteLine(bodyspace + "/" + innerspaces + "|" + innerspaces + "\\");
            }

            //body (parrallel)

            for (int row = 1; row <= size/2; row++)
            {
                var outerSpaces = new string(' ', ((size - 2)) / 2);
                var innerSpaces = new string(' ', ((size - 2)+1) /2);
                Console.WriteLine("|" + outerSpaces + "@" + innerSpaces + "|" + innerSpaces + "@" + outerSpaces + "|");
            }

            //body (upsidedown pyramid)

            for (int row = 1; row <= size/2; row++)
            {
                var innerSpaces = new string(' ', size - row);
                var outerSpaces = new string(' ', row - 1);
                Console.WriteLine(outerSpaces + "\\" + innerSpaces + "|" + innerSpaces + "/" + outerSpaces );
            }

            //bottom
            var spaces = new string(' ',size - size/2);
            var butt = new string('^', size / 2);
            string bottom = spaces + butt + "|" + butt;
            Console.WriteLine(bottom);

        }
    }
}
