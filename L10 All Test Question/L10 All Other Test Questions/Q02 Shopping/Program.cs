using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfChocolates = int.Parse(Console.ReadLine());
            double litersOfMilk = double.Parse(Console.ReadLine());

            double totalChocolateCost = Math.Round((numberOfChocolates * 0.65),2);
            double totalMilkCost = Math.Round((litersOfMilk * 2.70),2);

            double orangeCount = Math.Floor(numberOfChocolates * (1 - 0.35));
            double orangeCost = orangeCount * 0.20;

            double totalCost = totalChocolateCost + totalMilkCost + orangeCost;

            if (budget >= totalCost)
            {
                double leftover = Math.Round(budget - totalCost,2);
                Console.WriteLine($"You got this, {leftover:f2} money left!");
            }
            else
            {
                double remaining = Math.Round(totalCost - budget,2);
                Console.WriteLine($"Not enough money, you need {remaining:f2} more!");
            }

        }
    }
}
