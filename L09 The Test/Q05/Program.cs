using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //ears
            for (int row = 1; row <= size-1; row++)
            {
                var outerspaces = new string(' ', size - row -1);
                var innerspaces = new string(' ', row - 1);
                string ears = outerspaces + "/" + innerspaces + "|" + "  " + "|" + innerspaces + "\\";
                Console.WriteLine(ears);
            }

            var line = new string('-', size * 2 + 2);
            Console.WriteLine(line);

            // head
            
                string mostOfIt = new string(' ', size * 2);
                var betweeneyes = size + 1;
                var beforeeyes = size /2 - 1;
                var spacesBeforeEye = new string(' ', beforeeyes);
                var spacebetweenEye = new string(' ', betweeneyes);

                Console.WriteLine("|" +  spacesBeforeEye + "_" + spacebetweenEye + "_" + spacesBeforeEye + "|"); 
                
                Console.WriteLine("|" + spacesBeforeEye + "@" + spacebetweenEye + "@" + spacesBeforeEye + "|");

            for (int i = 1; i <= size/2; i++)
            {
                Console.WriteLine("|" + mostOfIt + "|");
            }

            var newspaces = new string(' ', size - 1);
            Console.WriteLine("|" + newspaces + "OO" + newspaces + "|");

            var newestSpaces = new string(' ', size - 2);
            Console.WriteLine("|" + newestSpaces + "/" + "  " + "\\" + newestSpaces + "|");

            Console.WriteLine("|" + newestSpaces + "||||" + newestSpaces + "|");

            //bottom
            for (int i = 1; i <= size; i++)
            {
                var first = new string('\\', i);
                var middle = new string('`', 2 * size - (2 * i) + 2);
                var second = new string('/', i);
                string bottom = first + middle + second;
                Console.WriteLine(bottom);
            }
            var leftbottom = new string('\\', size + 1);
            var rightbottom = new string('/', size + 1);
            Console.WriteLine(leftbottom + rightbottom);



        }
    }
}
