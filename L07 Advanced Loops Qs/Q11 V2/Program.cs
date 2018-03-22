using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //good example of how to use a number outside a block of code
            int readnumber;
            while (true)
            {
                readnumber = int.Parse(Console.ReadLine());

                if (readnumber % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            Console.WriteLine("Even number entered: {0}", readnumber);
            
        }
    }
}
