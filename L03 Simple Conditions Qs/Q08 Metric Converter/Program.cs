using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            string meter = "m";
            string miliMeter = "mm";
            string centiMeter = "cm";
            string miles = "mi";
            string inches = "in";
            string kilometers = "km";
            string feet = "ft";
            string yard = "yd";

            double meterTomilimeter = 1000;
            double meterTocentimeter = 100;
            double meterTomiles = 0.000621371192;
            double meterToinches = 39.3700787;
            double meterTokilometer = 0.001;
            double meterTofeet = 3.2808399;
            double meterToyard = 1.0936133;

            var number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (input == "m")
            {
                number = number*1;
            }
            else if (input == "mm")
            {
                number = number / meterTomilimeter;
            }
            else if (input == "cm")
            {
                number = number / meterTocentimeter;
            }
            else if (input == "mi")
            {
                number = number / meterTomiles;
            }
            else if (input == "in")
            {
                number = number / meterToinches;
            }
            else if (input == "km")
            {
                number = number / meterTokilometer;
            }
            else if (input == "ft")
            {
                number = number / meterTofeet;
            }
            else if (input == "yd")
            {
                number = number / meterToyard;
            }
            else
            { Console.WriteLine("invalid input"); }

            string output = Console.ReadLine();

            if (output == "m")
            {
                number = number*1;
            }
            else if (output == "mm")
            {
                number = number * meterTomilimeter;
            }
            else if (output == "cm")
            {
                number = number * meterTocentimeter;
            }
            else if (output == "mi")
            {
                number = number * meterTomiles;
            }
            else if (output == "in")
            {
                number = number * meterToinches;
            }
            else if (output == "km")
            {
                number = number * meterTokilometer;
            }
            else if (output == "ft")
            {
                number = number * meterTofeet;
            }
            else if (output == "yd")
            {
                number = number * meterToyard;
            }
            else
            { Console.WriteLine("invalid output"); }

            number = Math.Round(number, 8);
            Console.WriteLine(number);
        }
    }
}
