using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //toprow
            int sizeOfSpaces = size - 2;
            string topRowSpaces = new string(' ', sizeOfSpaces);
            Console.WriteLine($"@{topRowSpaces}@{topRowSpaces}@");

            int halfspace = size - 1;
            for (int row = 1; row <= (size+2)/3; row++)
            {
                halfspace -= 2;
                int outerdotcount = row - 1;
                string outerdots = new string('.', outerdotcount);
                string spacebar = new string(' ', halfspace);
                int leftover = (size * 2 - 1) - (outerdotcount + halfspace * 2 + 5);
                string middlestars = new string('.', leftover);

                if (row == 1)
                {
                    string firstLine = "*" + outerdots + "*" + spacebar + "*" + spacebar + "*" + outerdots + "*";
                    Console.WriteLine(firstLine);
                }


                else
                {
                    string line = "*" + outerdots + "*" + spacebar + "*" + middlestars + "*" + spacebar + "*" + outerdots + "*";
                    Console.WriteLine(line);
                }



            }

          
            //Almostdone
            int soCLose = size / 2;
            int jesusPls = (size - 3) / 2;
            string ohLord = new string('.', soCLose);
            string saveMe = new string('*', jesusPls);
            string almost = "*" + ohLord + saveMe + "." + saveMe + ohLord + "*";
            Console.WriteLine(almost);

            //finaltouch
            string finale = new string('*', size * 2 - 1);
            Console.WriteLine(finale);
            Console.WriteLine(finale);

        }
    }
}
