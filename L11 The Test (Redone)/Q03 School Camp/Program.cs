using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string season = Console.ReadLine();
            string sex = Console.ReadLine().ToLower();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            string sport = null;

            double totalPrice = 0;

            switch (season)
            {
                case "Winter":

                    switch (sex)
                    {
                        case "boys":
                            totalPrice = numberOfNights * numberOfStudents * 9.60;
                            sport = "Judo";
                            break;
                        case "girls":
                            totalPrice = numberOfNights * numberOfStudents * 9.60;
                            sport = "Gymnastics";
                            break;
                        case "mixed":
                            totalPrice = numberOfNights * numberOfStudents * 10;
                            sport = "Ski";
                            break;
                    }

                    break;
                case "Spring":

                    switch (sex)
                    {
                        case "boys":
                            totalPrice = numberOfNights * numberOfStudents * 7.20;
                            sport = "Tennis";
                            break;
                        case "girls":
                            totalPrice = numberOfNights * numberOfStudents * 7.20;
                            sport = "Athletics";
                            break;
                        case "mixed":
                            totalPrice = numberOfNights * numberOfStudents * 9.50;
                            sport = "Cycling";
                            break;
                    }

                    break;

                case "Summer":
                    switch (sex)
                    {
                        case "boys":
                            totalPrice = numberOfNights * numberOfStudents * 15;
                            sport = "Football";
                            break;
                        case "girls":
                            totalPrice = numberOfNights * numberOfStudents * 15;
                            sport = "Volleyball";
                            break;
                        case "mixed":
                            totalPrice = numberOfNights * numberOfStudents * 20;
                            sport = "Swimming";
                            break;
                    }

                    break;
             
            }

            if (numberOfStudents >= 50)
            {
                totalPrice *= 0.5;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                totalPrice *= 0.85;
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                totalPrice *= 0.95;
            }


            Console.WriteLine($"{sport} {totalPrice:f2} lv.");

        }
    }
}
