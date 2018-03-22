using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13_Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            //completely messed this one 
            int size = int.Parse(Console.ReadLine());

            int num = 1;

                for (int row = 0; num <= size; row++)
                {
                    for (int i = 0; i <= row; i++)
                    {
                        Console.Write(num+ " ");
                        num++;
                    
                        if (num > size)
                        {
                        break;
                        }


                    }
                    
                    Console.WriteLine();
                }
        }
    }
}
