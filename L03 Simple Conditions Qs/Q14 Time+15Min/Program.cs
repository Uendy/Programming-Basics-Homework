using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_Time_15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var min = minutes + 15;

            if (min < 60)
            { Console.WriteLine($"{hour:d1}:{min:d2}"); }
            else
            {
                hour = hour += 1;
                if (hour >= 24)
                {
                    hour = hour -24;
                    min = Math.Abs(60 - min);
                    Console.WriteLine($"{hour:d1}:{min:d2}");
                }
                else
                {
                    min = Math.Abs(60 - min);
                    Console.WriteLine($"{hour:d1}:{min:d2}");
                }
            }
        }
    }
}
