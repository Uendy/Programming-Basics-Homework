using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double length = double.Parse(Console.ReadLine());
            double area = 0;

            if (shape == "square")
            {
                area = length * length;
            }
            else if (shape == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                area = length * width;
            }
            else if (shape == "triangle")
            {
                double width = double.Parse(Console.ReadLine());
                area = (0.5 * length) * width;
            }
            else if (shape == "circle")
            {
                area = Math.PI * length * length;
            }
            else
            { Console.WriteLine("No such shape"); }

            area = Math.Round(area, 3);
            Console.WriteLine(area);
        }
    }
}
