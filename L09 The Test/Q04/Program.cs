using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            

            int digitsSum = 0;
            char digitCountOne = '0';
            char digitCountTwo = '0';
            char digitCountThree = '0';
            char digitCountFour = '0';
            char digitCountFive = '0';
            int  digitSpin = 1;
            
            int capitalLetterSum = 0;
            char cLSOne = '0';
            char clSTwo = '0';
            char clsThree = '0';
            char clsFour = '0';
            char clsFive = '0';
            int clSSpin = 1;
            
            int lowerLetterSum = 0;
            char llsOne = '0';
            char llsTwo = '0';
            char llsThree = '0';
            char llsFour = '0';
            char llsFive = '0';
            int llsSpin = 1;
            
            int misc = 0;
            char mOne = '0';
            char mTwo = '0';
            char mThree = '0';
            char mFour = '0';
            char mFive = '0';
            int mSpin = 1;
            

            for (int i = 1; i <= size; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (symbol >= '0' && symbol <= '9')
                {
                   
                    digitsSum += symbol;

                    if (digitSpin == 1)
                        digitCountOne = symbol;

                    else if (digitSpin == 2)
                        digitCountTwo = symbol;

                    else if (digitSpin == 3)
                        digitCountThree = symbol;

                    else if (digitSpin == 4)
                        digitCountFour = symbol;
                    
                    else if (digitSpin == 5)
                        digitCountFive = symbol;


                    digitSpin++;
                   
                }

                else if (symbol >= 'A' && symbol <= 'Z')
                {
                    capitalLetterSum += symbol;

                    if (clSSpin == 1)
                    { cLSOne = symbol; }
                    else if (clSSpin == 2)
                    { clSTwo = symbol; }
                    else if (clSSpin == 3)
                    { clsThree = symbol;}
                    else if (clSSpin == 4)
                    { clsFour = symbol; }
                    else if (clSSpin == 5)
                    { clsFive = symbol; }

                    clSSpin++;
                }

                else if (symbol >= 'a' && symbol <= 'z')
                {
                    lowerLetterSum += symbol;

                    if (llsSpin == 1)
                    { llsOne = symbol; }
                    else if (llsSpin == 2)
                    { llsTwo = symbol; }
                    else if (llsSpin == 3)
                    { llsThree = symbol; }
                    else if (llsSpin == 4)
                    { llsFour = symbol; }
                    else if (llsSpin == 5)
                    { llsFive = symbol; }

                    llsSpin++;
                }

                else
                {
                    misc += symbol;

                    if (mSpin == 1)
                    { mOne = symbol; }
                    else if (mSpin == 2)
                    { mTwo = symbol; }
                    else if (mSpin == 3)
                    { mThree = symbol; }
                    else if (mSpin == 4)
                    { mFour = symbol; }
                    else if (mSpin == 5)
                    { mFive = symbol; }

                    mSpin++;
                }

              
            }

            if (digitsSum > capitalLetterSum && digitsSum > lowerLetterSum && digitsSum > misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{digitsSum}");
                if (digitSpin == 2)
                { Console.WriteLine($"Combination of characters is:{ digitCountOne}"); }
                else if (digitSpin == 3)
                { Console.WriteLine($"Combination of characters is:{digitCountOne}{digitCountTwo}"); }
                else if (digitSpin == 4)
                { Console.WriteLine($"Combination of characters is:{digitCountOne}{digitCountTwo}{digitCountThree}"); }
                else if (digitSpin == 5)
                { Console.WriteLine($"Combination of characters is:{digitCountOne}{digitCountTwo}{digitCountThree}{digitCountFour}"); }
                else if (digitSpin == 6)
                { Console.WriteLine($"Combination of characters is:{digitCountOne}{digitCountTwo}{digitCountThree}{digitCountFour}{digitCountFive}"); }
            }

            else if (capitalLetterSum > digitsSum && capitalLetterSum > lowerLetterSum && capitalLetterSum > misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{capitalLetterSum}");
                if (clSSpin == 2)
                { Console.WriteLine($"Combination of characters is:{cLSOne}"); }
                else if (clSSpin == 3)
                { Console.WriteLine($"Combination of characters is:{cLSOne}{clSTwo}"); }
                else if (clSSpin == 4)
                { Console.WriteLine($"Combination of characters is:{cLSOne}{clSTwo}{clsThree}"); }
                else if (clSSpin == 5)
                { Console.WriteLine($"Combination of characters is:{cLSOne}{clSTwo}{clsThree}{clsFour}"); }
                else if (clSSpin == 6)
                { Console.WriteLine($"Combination of characters is:{cLSOne}{clSTwo}{clsThree}{clsFour}{clsFive}"); }
            }

            else if (lowerLetterSum > digitsSum && lowerLetterSum > capitalLetterSum && lowerLetterSum > misc)
            {
                Console.WriteLine($"Biggest ASCII sum is:{lowerLetterSum}");
                if (llsSpin ==2)
                { Console.WriteLine($"Combination of characters is:{llsOne}"); }
                else if (llsSpin == 3)
                { Console.WriteLine($"Combination of characters is:{llsOne}{llsTwo}"); }
                else if (llsSpin == 4)
                { Console.WriteLine($"Combination of characters is:{llsOne}{llsTwo}{llsThree}"); }
                else if (llsSpin == 5)
                { Console.WriteLine($"Combination of characters is:{llsOne}{llsTwo}{llsThree}{llsFour}"); }
                else if (llsSpin == 6)
                { Console.WriteLine($"Combination of characters is:{llsOne}{llsTwo}{llsThree}{llsFour}{llsFive}"); }
            }

            else
            {
                
                Console.WriteLine($"Biggest ASCII sum is:{misc}");
                if (mSpin ==2)
                { Console.WriteLine($"Combination of characters is:{mOne}"); }
                else if (mSpin == 3)
                { Console.WriteLine($"Combination of characters is:{mOne}{mTwo}"); }
                else if (mSpin == 4)
                { Console.WriteLine($"Combination of characters is:{mOne}{mTwo}{mThree}"); }
                else if (mSpin == 5)
                { Console.WriteLine($"Combination of characters is:{mOne}{mTwo}{mThree}{mFour}"); }
                else if (mSpin == 6)
                { Console.WriteLine($"Combination of characters is:{mOne}{mTwo}{mThree}{mFour}{mFive}"); }
            }

        }
    }
}
