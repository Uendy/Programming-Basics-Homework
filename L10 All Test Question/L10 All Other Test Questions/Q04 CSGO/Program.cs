using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	ak47 – 2700
            //•	awp – 4750
            //•	sg553 – 3500
            //•	grenade – 300
            //•	flash – 250
            //•	glock – 500
            //•	bazooka – 5600
            int numberOfWeapons = int.Parse(Console.ReadLine());
            int totalMoney = int.Parse(Console.ReadLine());
            int spending = 0;

            for (int turn = 1; turn <= numberOfWeapons; turn++)
            {
                string weaponName = Console.ReadLine();

                switch (weaponName)
                {
                    case "ak47":
                        spending += 2700;
                        break;

                    case "awp":
                        spending += 4750;
                        break;

                    case "sg553":
                        spending += 3500;
                        break;

                    case "grenade":
                        spending += 300;
                        break;

                    case "flash":
                        spending += 250;
                        break;

                    case "glock":
                        spending += 500;
                        break;

                    case "bazooka":
                        spending += 5600;
                        break;
                   
                   
                }
            }
            if (numberOfWeapons > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things! ");
                return;
            }

            if (totalMoney >= spending)
            {
                Console.WriteLine($"You bought all {numberOfWeapons} items! Get to work and defeat the bomb!");
            }
            else
            {
                int remaining = spending - totalMoney;
                Console.WriteLine($"Not enough money! You need {remaining} more money.");
            }
        }
    }
}
