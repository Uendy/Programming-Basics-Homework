using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_CT_NewString
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string middle = " | ";
            
            for (int row = 1; row <= size+1; row++)
            {
                //drawback is you can only put one symbol in the ' '
                //var middle = new string('|');
                var spaces = new string(' ',size+1-row);
                var stars = new string('*', row - 1);

                string line = spaces + stars + middle + stars;
                Console.WriteLine(line);

                //Console.Write(spaces);
                //Console.Write(stars);
                //Console.Write(" | ");
                //Console.Write(stars);
                //Console.Write(spaces);
                //Console.WriteLine();
            }
            
        }
    }
}
