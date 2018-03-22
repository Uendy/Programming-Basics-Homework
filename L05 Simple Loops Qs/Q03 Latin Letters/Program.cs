using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }

            // in ASCII decimal 97 to 122
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
