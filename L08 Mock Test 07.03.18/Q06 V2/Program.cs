using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycles = 0;

            char capitalLetter = char.Parse(Console.ReadLine());

            char letterOne = char.Parse(Console.ReadLine());

            char letterTwo = char.Parse(Console.ReadLine());

            char letterThree = char.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                for (char cL = 'A'; cL <= capitalLetter; cL++)
                {
                    Console.Write(cL);
                    for (char lone = 'a'; lone <= letterOne; lone++)
                    {
                        Console.Write(lone);
                        for (char ltwo = 'a'; ltwo <= letterTwo; ltwo++)
                        {
                            Console.Write(ltwo);
                            for (char lthree = 'a'; lthree <= letterThree; lthree++)
                            {
                                Console.Write(lthree);
                                for (int i = 0; i <= number; i++)
                                {
                                    Console.WriteLine(i);
                                    if (i != number)
                                    { cycles++; }
                                }
                                if (lthree != letterThree)
                                { cycles++; }
                            }
                            if (ltwo != letterTwo)
                            { cycles++; }
                        }
                        if (lone != letterOne)
                        { cycles++;}
                    }
                    if (cL != capitalLetter)
                    { cycles++;}
                }
                Console.WriteLine(cycles);
            }
            
        }
    }
}
