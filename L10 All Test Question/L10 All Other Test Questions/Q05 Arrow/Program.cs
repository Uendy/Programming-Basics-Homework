using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string wood = "|||";

            //arrowtip
            string toppest = new string('_', (size + 5) / 2);
            Console.WriteLine(toppest + "^" + toppest);

            string sectoppest = new string('_', (size + 3) / 2);
            Console.WriteLine(sectoppest + "/" + "|" + "\\" + sectoppest);

            int dashes = size / 2;
            for (int row = 1; dashes >= 1 ; row++)
            {
                string dots = new string('.', row - 1);
                string botdash = new string('_', dashes);

                string arrowtip = botdash + "/" + dots + wood + dots + "\\" + botdash;
                Console.WriteLine(arrowtip);
                dashes--;
            }

            // reverse
            Console.Write(new string('_', (size + 5 - 9) / 2));
            Console.Write("/..|||..\\");   
            Console.Write(new string('_', (size + 5 - 9) / 2));
            Console.WriteLine();           
                                           
            Console.Write(new string('_', (size + 5 - 7) / 2));
            Console.Write("/.|||.\\");     
            Console.Write(new string('_', (size + 5 - 7) / 2));
            Console.WriteLine();

            //body :
            int body = (size + 2) / 2;
            string bodydashes = new string('_', body);
            for (int row = 1; row <= size+1; row++)
            {
                if (row == size+1)
                {
                    string boyohboy = bodydashes + "~~~" + bodydashes;
                    Console.WriteLine(boyohboy);
                }
                else
                {
                    string bodeih = bodydashes + wood + bodydashes;
                    Console.WriteLine(bodeih);
                }

            }

            //bottom
            int bottomdashes = size / 2;
            for (int row = 1; row <= size/2; row++)
            {
                
                int bottomdots = row - 1;

                string ends = new string('_', bottomdashes);
                string finaldots = new string('.', bottomdots);

                string lordpls = ends + "//" + finaldots+ "!" + finaldots+ "\\\\" + ends; 
                Console.WriteLine(lordpls);

                bottomdashes--;
            }

        }
    }
}
