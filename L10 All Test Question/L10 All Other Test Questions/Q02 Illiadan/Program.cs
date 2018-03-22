using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Illiadan
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPlayers = double.Parse(Console.ReadLine());
            double onePlayerDamage = double.Parse(Console.ReadLine());
            double illiadanHealth = double.Parse(Console.ReadLine());

            double totalDamage = numberOfPlayers * onePlayerDamage;

            if (totalDamage >= illiadanHealth)
            {
                double overkill = totalDamage - illiadanHealth;
                Console.WriteLine($"Illidan has been slain! You defeated him with {overkill} points.");
            }
            else
            {
                double unsufficient = illiadanHealth - totalDamage;
                Console.WriteLine($"You are not prepared! You need {unsufficient} more points.");
            }
        }
    }
}
