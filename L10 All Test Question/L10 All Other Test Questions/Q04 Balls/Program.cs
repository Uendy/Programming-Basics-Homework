using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;
            int redPoint = 0;
            int orangePoints = 0;
            int yellowPoints = 0;
            int whitePoints = 0;
            int others = 0;
            int blackTimes = 0;
            
            int size = int.Parse(Console.ReadLine());

            for (int spin = 1; spin <= size; spin++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        totalPoints += 5;
                        redPoint ++;
                        break;

                    case "orange":
                        totalPoints += 10;
                        orangePoints ++;
                        break;

                    case "yellow":
                        totalPoints += 15;
                        yellowPoints ++;
                        break;

                    case "white":
                        totalPoints += 20;
                        whitePoints ++;
                        break;

                    case "black":
                        totalPoints /= 2;
                        blackTimes++;
                        break;

                    default:
                        others++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redPoint}");
            Console.WriteLine($"Points from orange balls: {orangePoints}");
            Console.WriteLine($"Points from yellow balls: {yellowPoints}");
            Console.WriteLine($"Points from white balls: {whitePoints}");
            Console.WriteLine($"Other colors picked: {others}");
            Console.WriteLine($"Divides from black balls: {blackTimes}");
        }
    }
}
