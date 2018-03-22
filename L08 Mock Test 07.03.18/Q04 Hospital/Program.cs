using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;

            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0) // review
                {
                    
                    if (treated < untreated)
                    {
                        doctors++;
                    }

                }

                int patients = int.Parse(Console.ReadLine());

                if (doctors >= patients)
                {
                    treated += patients;
                }
                else // doctors < pat
                {
                    treated += doctors;

                    var missed = (patients - doctors);
                    untreated += missed;
                }

            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
