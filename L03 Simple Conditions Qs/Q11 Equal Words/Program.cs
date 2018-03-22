using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            // string example = Console.ReadLine().ToLower();
            // or var example = Console.ReadLine().ToLower();
            // or .ToUpper
            string word = "word1";
            string word1 = Console.ReadLine().ToLower();
            string word2 = Console.ReadLine().ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
