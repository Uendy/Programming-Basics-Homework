using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    class Program
    {
        static void Main(string[] args)
        {
            int holeWidth = int.Parse(Console.ReadLine());
            int holeLength = int.Parse(Console.ReadLine());
            
            int pictureLength = int.Parse(Console.ReadLine());//sq

            int numberOfPictures = int.Parse(Console.ReadLine());

            int holeArea = holeLength * holeWidth;

            int pictureArea = pictureLength * pictureLength;
            int allPictureArea = pictureArea * numberOfPictures;

            if (holeArea < allPictureArea)
            {
                var diff = Math.Abs(holeArea - allPictureArea);
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {diff} bigger than hole area.");
            }

            else
            {
                var diff = Math.Abs(allPictureArea - holeArea);
                Console.WriteLine($"The pictures fit in the hole. Hole area is {diff} bigger than pictures area.");
            }

            

        }
    }
}
