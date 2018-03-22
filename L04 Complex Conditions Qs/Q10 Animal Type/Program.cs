using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                 //case "crocodile":
                 //case "snake":
                 //case "tortoise":
                 // Console.WriteLine("reptile");
                 // break;
                case string slitherin when (animal == "snake" || animal == "tortoise" || animal == "crocodile"):
                    Console.WriteLine("reptile");
                    break;

                default :
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
