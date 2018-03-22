using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n ; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                
            }
            Console.WriteLine(sum);
            
           
        }
    }
}
