using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01_Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int pauseTime = int.Parse(Console.ReadLine());
            double packCost = double.Parse(Console.ReadLine());
            double adventureCost = double.Parse(Console.ReadLine());
            double coffeeCost = double.Parse(Console.ReadLine());

            double moneySpent = coffeeCost + adventureCost * 2 + packCost * 3;
            moneySpent = Math.Round(moneySpent,2);
            Console.WriteLine($"{moneySpent:f2}");

            int remainingTime = pauseTime - 5 - 2 * 3 - 2 * 2;
            Console.WriteLine(remainingTime);
        }
    }
}

