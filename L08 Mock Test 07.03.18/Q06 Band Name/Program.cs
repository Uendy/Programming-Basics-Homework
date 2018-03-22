using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_Band_Name
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

            for (char cL = 'A'; cL <= capitalLetter; cL++)
            {
                for (char lone = 'a'; lone <= letterOne; lone++)
                {
                    for (char ltwo = 'a'; ltwo <= letterTwo; ltwo++)
                    {
                        for (char lthree = 'a'; lthree <= letterThree; lthree++)
                        {
                            for (int i = 0; i <= number; i++)
                            {
                                if (i != number)
                                cycles++;
                            }
                            if (lthree != letterThree)
                            cycles++;
                        }
                        if (ltwo != letterTwo)
                        cycles++;
                    }
                    if (lone != letterOne)
                    cycles++;
                }
                if (cL != capitalLetter)
                cycles++;
            }
            Console.WriteLine(cycles);
        }
    }
}
