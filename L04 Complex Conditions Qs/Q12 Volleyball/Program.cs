using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int home = int.Parse(Console.ReadLine());
            double played = 0.0;
            int sofia = 48 - home;

            played = (sofia * 0.75) + ((2.0/3.0) * holidays) + home;

            switch (year)
            {
                case "leap":
                    played = played + (played * 0.15);
                    break;

                case "normal":
                    played = played;
                    break;
            }

            Console.WriteLine(Math.Floor(played));    
        }
    }
}
