using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Crown
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

            //2ndrow
            int sizeOfSecSpaces = size - 3;
            string secondRowSpaces = new string(' ', sizeOfSecSpaces);
            Console.WriteLine($"**{secondRowSpaces}*{secondRowSpaces}**");

            //thirdrow
            int spaces = (((size * 2 - 1) - 9) / 2);
            int middledotCount = 0;
            for (int row = 1; row <= size/3; row++)
            {
                string innerSpaces = new string(' ', spaces);
                string dots = new string('.', row);
                string middleDots = new string('.', row + middledotCount);

                if (row == 1)
                {
                    string firstRow = "*" + dots + "*" + innerSpaces + "*" + dots + "*" + innerSpaces + "*" + dots + "*";
                    Console.WriteLine(firstRow);
                }

                else
                {
                    string otherRows = "*" + dots + "*" + innerSpaces + "*" + middleDots + "*" + innerSpaces + "*" + dots + "*";
                    Console.WriteLine(otherRows);
                    
                }

                
                spaces -= 2;
                middledotCount++;
            }
            //tailwaggy
            int outerSpaces = (size + 2) / 3;
            int innertSpaces = size - 3;

            string outSpace = new string('.', outerSpaces);
            string inSpace = new string('.', innertSpaces);
            string lastBit = "*" + outSpace + "*" + inSpace + "*" + outSpace + "*";
            Console.WriteLine(lastBit);

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
