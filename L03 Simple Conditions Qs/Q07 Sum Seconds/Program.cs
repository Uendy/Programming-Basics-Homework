using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());

            int time = t1 + t2 + t3;

            int minutes = time / 60;
            int seconds = time % 60;
            if (time > 10)
            { Console.WriteLine($"{minutes}:{seconds:d2}"); }
            else
            { Console.WriteLine($"0:{seconds:d2}"); }


        }
    }
}
