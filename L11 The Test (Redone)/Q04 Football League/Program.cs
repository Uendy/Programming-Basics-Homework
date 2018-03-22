using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Общият брой на феновете НЕ надвишава капацитета на стадиона.
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double numberOfFans = double.Parse(Console.ReadLine());

            int fansOfTeamA = 0; //A,B
            int fansOfTeamB = 0; // V,G

            int fansInSecA = 0;
            int fansInSecB = 0;

            int fansInSecV = 0;
            int fansInSecG = 0;

            for (int fan = 1; fan <= numberOfFans; fan++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        fansInSecA++;
                        fansOfTeamA++;
                        break;

                    case "B":
                        fansInSecB++;
                        fansOfTeamA++;
                        break;

                    case "V":
                        fansInSecV++;
                        fansOfTeamB++;
                        break;

                    case "G":
                        fansInSecG++;
                        fansOfTeamB++;
                        break;
                 
                }
            }

            double proA = ((fansInSecA * 100) / numberOfFans);
            double proB = ((fansInSecB * 100) / numberOfFans);
            double proV = ((fansInSecV * 100) / numberOfFans);
            double proG = ((fansInSecG * 100) / numberOfFans);
            double proPeople = 100* numberOfFans / stadiumCapacity ;
           

            Console.WriteLine($"{proA:f2}%");
            Console.WriteLine($"{proB:f2}%");
            Console.WriteLine($"{proV:f2}%");
            Console.WriteLine($"{proG:f2}%");
            Console.WriteLine($"{proPeople:f2}%");
        }
    }
}
