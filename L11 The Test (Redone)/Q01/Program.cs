using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyCost = double.Parse(Console.ReadLine());
            double beerLiter= double.Parse(Console.ReadLine());
            double wineLiter = double.Parse(Console.ReadLine());
            double rakiaLiter = double.Parse(Console.ReadLine());
            double whiskeyLiter = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            double totalWhiskey = whiskeyCost * whiskeyLiter;
            totalPrice += totalWhiskey;

            double rakiaPrice = whiskeyCost * 0.5;
            double totalRakia = rakiaLiter * rakiaPrice;
            totalPrice += totalRakia;

            double wineCost = rakiaPrice * 0.6;
            double totalWine = wineCost * wineLiter;
            totalPrice += totalWine;

            double beerCost = rakiaPrice * 0.2;
            double totalBeer = beerCost * beerLiter;
            totalPrice += totalBeer;

            
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
