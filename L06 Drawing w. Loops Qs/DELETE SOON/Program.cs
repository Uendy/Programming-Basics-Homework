using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELETE_SOON
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new string('*', 10);

            for (int row =1; row <= 10; row++)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
