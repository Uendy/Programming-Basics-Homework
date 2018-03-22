using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //toprow 
            var toprowdashes = new string('_', (size - 1) / 2);
            var eventoprowstars = new string('*', 2);
            var oddtoprowstars = new string('*', 1);
            char star = '*';

            if (size % 2 == 0) //even 
            {
                string toprow = toprowdashes + eventoprowstars + toprowdashes;
                Console.WriteLine(toprow);

                // middle:
                for (int uprow = 1; uprow <= size/2 -1; uprow++)
                {
                    var middledashes = new string('_', uprow * 2);
                    var borderdashes = new string('_', size / 2 - 1- uprow);
                    string middle = borderdashes + star + middledashes + star + borderdashes;
                    Console.WriteLine(middle);
                }

                //bottom :
                for (int botrow = 1; botrow <= size/2 -1; botrow++)
                {
                    var borderdashes = new string('_', botrow);
                    var middledashes = new string('_', size - 2 - 2 * botrow);

                    string bottom = borderdashes + star + middledashes + star + borderdashes;
                    Console.WriteLine(bottom);
                }
                
            }
            else // odd
            {
                string toprow = toprowdashes + oddtoprowstars + toprowdashes;
                Console.WriteLine(toprow);

                // middle:
                for (int uprow = 1; uprow <= size/2; uprow++)
                {
                    var borderdashes = new string('_', size / 2 - uprow);
                    var middledashes = new string('_', size - 2 - 2*(size / 2 - uprow));
                    string middle = borderdashes + star + middledashes + star + borderdashes;
                    Console.WriteLine(middle);
                }

                ////bottom:
                //for (int botrow = 1; botrow <= size/2; botrow++)
                //{
                //    var borderdashes = new string('_', botrow);
                //    var middledashes = new string('_', size - 2 - 2 * botrow);

                //    if (botrow == size / 2)
                //    {
                //        middledashes = new string ('_', size - 2 * botrow);
                //    }
                //    else
                //    {
                //        string bottom = borderdashes + star + middledashes + star + borderdashes;
                //        Console.WriteLine(bottom);
                //    }
                //}
            }

        }
    }
}
