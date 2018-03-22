using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_V3__Try_and_Catch__
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int woopdyda = int.Parse(Console.ReadLine());
            }

            catch 
            {
                Console.WriteLine("Woopsy Error Alert");
            }
        }
    }
}
