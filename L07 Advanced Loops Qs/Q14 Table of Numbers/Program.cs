using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_Table_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 1; row <= size; row++)
            {
                num = row;
                Console.Write(num++ + " ");


                for (int coll = 1; coll <= size - 1; coll++)
                {
                    if (num <= size)
                    { { Console.Write(num++ + " "); } }

                    else if (num > size)
                    {
                        Console.Write(size- ((num++)-size) + " ");
                    }

                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
