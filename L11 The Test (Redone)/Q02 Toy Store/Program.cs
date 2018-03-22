using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_Toy_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Пъзел – 2.60 лв.
            //•	Говореща кукла – 3 лв.
            //•	Плюшено мече – 4.10 лв.
            //•	Миньон – 8.20 лв.
            //•	Камионче – 2 лв.
            double vacationCost = double.Parse(Console.ReadLine());
            int puzzleCounts = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int stuffedCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double totalSale = 0;
            int toySold = puzzleCounts + dollCount + stuffedCount + minionCount + truckCount;

            double puzzleProfit = puzzleCounts * 2.60;
            double dollProfit = dollCount * 3.0;
            double stuffedProfit = stuffedCount * 4.10;
            double minionProfit = minionCount * 8.20;
            double truckProfit = truckCount * 2;

            totalSale = puzzleProfit + dollProfit + stuffedProfit + minionProfit + truckProfit;

            if (toySold >= 50)
            {
                totalSale *= 0.75;
            }

            totalSale *= 0.9; //rent

            if (totalSale >= vacationCost)
            {
                double leftover = totalSale - vacationCost;
                Console.WriteLine($"Yes! {leftover:f2} lv left.");
            }
            else
            {
                double remaining = vacationCost - totalSale;
                Console.WriteLine($"Not enough money! {remaining:f2} lv needed.");
            }
        }
    }
}
    