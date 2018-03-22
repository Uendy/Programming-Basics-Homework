using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string readnumber = Console.ReadLine();
            //int readnumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= readnumber.Length-1; i++)
            {

                //decimal 
                char point = '.';
                bool decimalcheck = point == readnumber[i];
                if (decimalcheck)
                {
                    Console.WriteLine("Invalid number!");
                }

                //string
                bool stringcheck = int.Parse(readnumber) % 10 == readnumber[i] - '0';
                if (stringcheck)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                //even
                bool evencheck = int.Parse(readnumber) % 2 != 0;
                if (evencheck == true)
                {
                    Console.WriteLine("This number is not even.");
                }
                else
                {
                    Console.WriteLine($"Even number entered: {readnumber}");
                }
            }

        }
    }
}
