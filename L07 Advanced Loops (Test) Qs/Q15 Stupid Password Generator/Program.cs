using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15_Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int letters = int.Parse(Console.ReadLine());
            int mathLetter = (char)letters + 'a';

            int numOne = 0;
            int numTwo = 0;
            char letterOne = 'a';
            char letterTwo = 'a';
            int i = 0;


            for (numOne = 1; numOne <= numbers - 1; numOne++)
            {
                if (numOne < numbers - 1)
                { Console.Write(numOne); }

                else// (numOne == numbers - 1)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", numOne, numTwo, letterOne, letterTwo, i);
                    break;
                }

                for (numTwo = 1; numTwo <= numbers - 1; numTwo++)
                {
                    if (numTwo <= numbers - 1)
                    { Console.Write(numTwo); }

                    else// (numTwo == numbers - 1)
                    {
                        Console.WriteLine("{0}{1}{2}{3}{4}", numOne, numTwo, letterOne, letterTwo, i);
                        break;
                    }
                    for ( letterOne = 'a'; letterOne <= mathLetter; letterOne++)
                    {
                        if (letterOne < mathLetter)
                        { Console.Write(letterOne); }

                        else// (letterOne == mathLetter)
                        {
                            Console.WriteLine("{0}{1}{2}{3}{4}", numOne, numTwo, letterOne, letterTwo, i);
                            break;
                        }
                        for ( letterTwo = 'a'; letterTwo <= mathLetter; letterTwo++)
                        {
                            if (letterTwo < mathLetter)
                            { Console.Write(letterTwo); }
                        

                            else// (letterTwo == mathLetter)
                            { Console.WriteLine("{0}{1}{2}{3}{4}", numOne, numTwo, letterOne, letterTwo, i);
                                break;
                            }
                            for ( i = numTwo + 1; i <= numbers; i++)
                            {
                                if (i < numbers)
                                { Console.WriteLine(i); }

                                else // (i == numbers)
                                {
                                    Console.WriteLine("{0}{1}{2}{3}{4}",numOne, numTwo, letterOne, letterTwo,i);
                                     break;
                                }
                            }
                           // break;
                        }
                        //break;
                    }
                    //break;
                }
               // break;
            }
        }

    
    }
}
