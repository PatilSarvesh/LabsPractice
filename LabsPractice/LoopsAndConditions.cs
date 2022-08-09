using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsPractice
{
    internal class LoopsAndConditions
    {
        public static void Main()
        {
            double term = 0;
            double sum = 0;
            for (double i = 0; i < 1000; i++)
            {
                 term =  1.0 / (2.0 * i + 1);
                if (i%2==0)
                {
                    Console.Write($" {term}");
                    sum += term;
                }
                else
                {
                    term = term * -1;
                    Console.Write($" {term}");
                    sum += term;
                }

                
            }
            Console.WriteLine(sum);

        }
    }
}
