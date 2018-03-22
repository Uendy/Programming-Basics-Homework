using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Part_3
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

            int holyspaces = size - 3;
            for (int row = 1; row < size/2; row++)
            {
                int outerdotty = row - 1;
                string outerdots = new string('.', outerdotty);
                string popeSpaces = new string(' ', holyspaces);
                int middlefiddle = (size * 2 - 1) - 5 - (holyspaces * 2 - outerdotty * 2);
                string middlediddle = new string('.', middlefiddle);

                string line = "*" + outerdots + "*" + popeSpaces + "*" + middlediddle + "*" + popeSpaces + "*" + outerdots + "*";
                Console.WriteLine(line);



                holyspaces-=2;

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
