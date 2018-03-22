using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
         

            for (int row = 1; row <= size; row++)
            {
                int num = row;
                Console.Write($"{num++} ");

                for (int coll = 1; coll <= size-1; coll++)
                {
                    if (num > size)
                    {
                        
                        Console.Write(2*size-num +" ");
                        
                    }
                    else

                    {
                        Console.Write($"{num} ");
                    }
                    num++;                    
                }

                Console.WriteLine();
            }
        }
    }
}
