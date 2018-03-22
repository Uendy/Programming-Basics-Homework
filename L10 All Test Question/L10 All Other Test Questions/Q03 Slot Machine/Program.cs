using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());
            int numberOne = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOne; i++)
            {
                symbolOne++;
            }


            char symbolTwo = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberTwo; i++)
            {
                symbolTwo++;
            }

            char symbolThree = char.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberThree; i++)
            {
                symbolThree++;
            }

            string restult = string.Format("{0}{1}{2}", symbolOne, symbolTwo, symbolThree);

            if (restult == "777")
            {
                Console.WriteLine(restult);
                Console.WriteLine("*** JACKPOT ***");
            }
            else if (restult == "@@@")
            {
                Console.WriteLine(restult);
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
            else
            {
                Console.WriteLine(restult);
            }
            

        }
    }
}
