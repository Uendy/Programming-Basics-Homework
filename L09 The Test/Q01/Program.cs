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
            double distance = double.Parse(Console.ReadLine());
            double truck = double.Parse(Console.ReadLine());
            double speedDIff = double.Parse(Console.ReadLine());
            double realDiff = speedDIff * 3.6;

            double car = truck + realDiff;

            double truckTime = Math.Ceiling(distance / truck);
            double carTime = Math.Ceiling(distance / car);

            Console.WriteLine($"The truck arrived after {truckTime} hours");
            Console.WriteLine($"The car arrived after {carTime} hours");

        }
    }
}
