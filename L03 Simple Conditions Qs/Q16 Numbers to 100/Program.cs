using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16_Numbers_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 )
            { Console.WriteLine("invalid number"); }
            if(number > 100)
            { Console.WriteLine("invalid number"); }

            if (number == 100)
            { Console.WriteLine("one hundred"); }
            if (number == 0)
            { Console.WriteLine("zero"); }
           

            if (number >= 20 && number < 100)
            {

                if (number % 10 != 0)
                {
                    if (number / 10 == 2)
                    {
                        Console.Write("twenty ");
                        if (number % 10 == 1)
                        {
                            Console.WriteLine("one");
                        }
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 3)
                    {
                        Console.Write("thirty ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 4)
                    {
                        Console.Write("forty ");
                        if (number % 10 == 1)
                        {
                            Console.WriteLine("one");
                        }
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 5)
                    {
                        Console.Write("fifty ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 6)
                    {
                        Console.Write("sixty ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 7)
                    {
                        Console.Write("seventy ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 8)
                    {
                        Console.Write("eighty ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }
                    else if (number / 10 == 9)
                    {
                        Console.Write("ninety ");
                        if (number % 10 == 2)
                        {
                            Console.WriteLine("two");
                        }
                        else if (number % 10 == 3)
                        {
                            Console.WriteLine("three");
                        }
                        else if (number % 10 == 4)
                        {
                            Console.WriteLine("four");
                        }
                        else if (number % 10 == 5)
                        {
                            Console.WriteLine("five");
                        }
                        else if (number % 10 == 6)
                        {
                            Console.WriteLine("six");
                        }
                        else if (number % 10 == 7)
                        {
                            Console.WriteLine("seven");
                        }
                        else if (number % 10 == 8)
                        {
                            Console.WriteLine("eight");
                        }
                        else if (number % 10 == 9)
                        {
                            Console.WriteLine("nine");
                        }
                    }

                   
                }

                if (number % 10 == 0)
                {
                    if (number / 10 == 2)
                    { Console.WriteLine("twenty"); }
                    else if (number / 10 == 3)
                    { Console.WriteLine("thirty"); }
                    else if (number / 10 == 4)
                    { Console.WriteLine("forty"); }
                    else if (number / 10 == 5)
                    { Console.WriteLine("fifty"); }
                    else if (number / 10 == 6)
                    { Console.WriteLine("sixty"); }
                    else if (number / 10 == 7)
                    { Console.WriteLine("seventy"); }
                    else if (number / 10 == 8)
                    { Console.WriteLine("eighty"); }
                    else if (number / 10 == 9)
                    { Console.WriteLine("ninety"); }
                }
            }

            if (number < 20)
            {
                if (number == 1)
                { Console.WriteLine("one"); }
                if (number == 2)
                { Console.WriteLine("two"); }
                if (number == 3)
                { Console.WriteLine("three"); }
                if (number == 4)
                { Console.WriteLine("four"); }
                if (number == 5)
                { Console.WriteLine("five"); }
                if (number == 6)
                { Console.WriteLine("six"); }
                if (number == 7)
                { Console.WriteLine("seven"); }
                if (number == 8)
                { Console.WriteLine("eight"); }
                if (number == 9)
                { Console.WriteLine("nine"); }
                if (number == 10)
                { Console.WriteLine("ten"); }
                if (number == 11)
                { Console.WriteLine("eleven"); }
                if (number == 12)
                { Console.WriteLine("twelve"); }
                if (number == 13)
                { Console.WriteLine("thirteen"); }
                if (number == 14)
                { Console.WriteLine("fourteen"); }
                if (number == 15)
                { Console.WriteLine("fifteen"); }
                if (number == 16)
                { Console.WriteLine("sixteen"); }
                if (number == 17)
                { Console.WriteLine("seventeen"); }
                if (number == 18)
                { Console.WriteLine("eighteen"); }
                if (number == 19)
                { Console.WriteLine("nineteen"); }
            }
        }

      
    }
}
