using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6_Kleines1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int multiplicator = 1;

            while (n <= 10)
            {
                while (multiplicator <= 10)
                {
                    Console.Write($"{n * multiplicator}\t");
                    multiplicator++;
                }
                Console.Write("\n");
                multiplicator = 1;
                n++;
            }
        }
    }
}
