using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01_PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double total;

            double afterDiscount = (processorPrice + videoCardPrice) * (1 - discount);
            total = afterDiscount;

            double totalRamPrice = ramPrice * ramQuantity;
            total += totalRamPrice;

            total *= 1.57; // currency converted

            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
