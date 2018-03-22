using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Attempt_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int horizontal = int.Parse(Console.ReadLine());
            int vertical = int.Parse(Console.ReadLine());

            //bool BottomLeftSq = length > 0 && length <= horizontal && length == vertical;
            //bool BottomMiddleSq = length == 2 * horizontal && length == vertical;
            //bool BottomRightSq = length == 3 * horizontal && length == vertical;


            //bool onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            //bool onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            //bool onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            //bool onDownSide = (y == y2) && (x >= x1) && (x <= x2);
            //if (onLeftSide || onRightSide || onUpSide || onDownSide)
            //    Console.WriteLine("Border")

            bool BottomRectLS = length == horizontal && vertical >= 0 && vertical <= length;
            bool BottomRectUS = vertical == length && horizontal >= 0 && horizontal <= length;

            if (BottomRectLS || BottomRectUS)
            {
                Console.WriteLine("border");
            }
            else if ()
           
        }
    }
}
