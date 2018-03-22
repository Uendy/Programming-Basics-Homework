using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            //top part
            char rightslash = '/';
            var topspikes = new string('^', size / 2);
            char leftslash = '\\';
            var dashes = new string('_', size / 2);

            string corner = rightslash + topspikes + leftslash;
            string top = corner + dashes + corner;

            Console.WriteLine(top);
            //


            //middle bit
            for (int row = 1; row <= size-2; row++)
            {
                if (size <= 4)
                { 
}
                if (size > 4)
                {
                    if (row == size - 2)
                    {
                        Console.Write('|');

                        for (int specialrow = 1; specialrow <= size - 1; specialrow++)
                        {
                            Console.Write(' ');
                        }

                        Console.Write(dashes);

                        for (int specialrow = 1; specialrow <= size - 1; specialrow++)
                        {
                            Console.Write(' ');
                        }

                        Console.WriteLine('|');

                    }
                    else
                    {
                        //
                        Console.Write('|');
                        for (int inrow = 1; inrow <= (size * 2) - 2; inrow++)
                        {
                            Console.Write(' ');
                        }
                        Console.WriteLine('|');
                    }
                }
            }
            //

            //bottom bit
            var spaces = new string(' ', size / 2);
            string bottomcorner = leftslash + dashes + rightslash;

            Console.Write(bottomcorner);
            Console.Write(spaces);
            Console.Write(bottomcorner);


        }
    }
}
