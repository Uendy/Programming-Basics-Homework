using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Castel_V2
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
            if (size <= 4)
            {
                string corner = rightslash + topspikes + leftslash;
                string top = corner + corner;
                Console.WriteLine(top);
            }
            else
            {
                string corner = rightslash + topspikes + leftslash;
                string top = corner + dashes + corner;

                Console.WriteLine(top);
            }
            //

            //middle part
            char border = '|';
            for (int row = 1; row <= size-2; row++)
            {
                if (size <= 4)
                {
                    Console.Write(border);
                    for (int innerspaces = 1; innerspaces <= size + (size / 2); innerspaces++)
                    {
                        Console.Write(' ');
                    }
                    Console.WriteLine(border);
                }
                else
                {
                    if (row == size - 2) //the last middle part
                    {
                        if (size % 2 != 0)
                        {
                            Console.Write(border);

                            for (int magic = 1; magic <= row; magic++)
                            {
                                Console.Write(' ');
                            }

                            Console.Write(dashes);

                            for (int magic = 1; magic <= row; magic++)
                            {
                                Console.Write(' ');
                            }

                            Console.WriteLine(border);
                        }
                        else
                        {
                            Console.Write(border);

                            for (int magic = 1; magic <= row; magic++)
                            {
                                Console.Write(' ');
                            }

                            Console.Write(dashes);

                            for (int magic = 1; magic <= row; magic++)
                            {
                                Console.Write(' ');
                            }

                            Console.WriteLine(border);

                        }
                    }
                    else
                    {
                        // all the other middle parts
                        Console.Write(border);

                        for (int innerrow = 0; innerrow <= (size * 2) - 2; innerrow++)
                        {
                            Console.Write(' ');
                        }
                        
                        Console.WriteLine(border);
                    }
                }
            }



            //bottom bit
            if (size <= 4)
            {
                string bottomcorner = leftslash + dashes + rightslash;

                Console.Write(bottomcorner);
                Console.Write(bottomcorner);
            }
            else
            {
                var spaces = new string(' ', size / 2);
                string bottomcorner = leftslash + dashes + rightslash;

                Console.Write(bottomcorner);
                Console.Write(spaces);
                Console.Write(bottomcorner);
            }
            //
        }
    }
}
