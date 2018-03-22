using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
          

            //walls = green paint = 3msq

            //left and right side
            double side = length * length / 2;
            double sides = side * 2;

            //back (might be off not sure)
            double backSq = (length / 2 * length / 2);
            double backTri = (length / 2 * (height - length / 2)) / 2;
            double back = (backSq + backTri);

            //front
            double front = back - (length / 5 * length / 5);

            double walls = sides + back + front;
            double greenPaint = walls / 3 ;
            greenPaint = Math.Round(greenPaint, 2);
            Console.WriteLine($"{greenPaint:f2}");


            //roof = red paint
            double roof = Math.Pow(length, 2);
            double redPaint = roof / 5 ;
            redPaint = Math.Round(redPaint, 2);
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
