using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLQs_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            var min = minute + 15;

            if (hour >= 23)
            {
                if (min >= 60)
                {
                    hour = 0;
                    min = min - 60;
                    Console.WriteLine($"{hour}:{min:d2}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{min:d2}");
                }
            }
            else if (hour < 23)
            {
                if (min >= 60)
                {
                    hour = hour + 1;
                    min = min - 60;
                    Console.WriteLine($"{hour}:{min:d2}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{min:d2}");
                }
            }



        }
    }
}
