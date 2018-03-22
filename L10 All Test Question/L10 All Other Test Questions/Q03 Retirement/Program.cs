using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Retirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int workTime = int.Parse(Console.ReadLine());

            switch (gender)
            {
                case "male":
                    if (age >= 64 && workTime >= 38)
                    {
                        Console.WriteLine($"Ready to retire at {age} and {workTime} years of experience!");
                    }
                    else if (age >= 64 && workTime < 38)
                    {
                        int workDiff = 38 - workTime;
                        Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {workDiff}.");
                    }
                    else if (age < 64 && workTime >= 38)
                    {
                        int ageDiff = 64 - age;
                        Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {ageDiff}.");
                    }
                    else if (age < 64 && workTime < 38)
                    {
                        int ageDIff = 64 - age;
                        int workDiff = 38 - workTime;
                        Console.WriteLine($"Too early. Years left to retirement: {ageDIff}. Work experience left to retirement: {workDiff}.");
                    }
                break;

                case "female":
                    if (age >= 61 && workTime >= 35)
                    {
                        Console.WriteLine($"Ready to retire at {age} and {workTime} years of experience!");
                    }
                    else if (age >= 61 && workTime < 35)
                    {
                        int workDiff = 35 - workTime;
                        Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {workDiff}.");
                    }
                    else if (age < 61 && workTime >= 35)
                    {
                        int ageDiff = 61 - age;
                        Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {ageDiff}.");
                    }
                    else if (age < 61 && workTime < 35)
                    {
                        int ageDiff = 61 - age;
                        int workDiff = 35 - workTime;
                        Console.WriteLine($"Too early. Years left to retirement: {ageDiff}. Work experience left to retirement: {workDiff}.");
                    }
                break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
