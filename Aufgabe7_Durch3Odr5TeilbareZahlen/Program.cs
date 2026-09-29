using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7_Durch3Odr5TeilbareZahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            int[] list = new int[30];
            int index = 0;
            while (n <= 30)
            {
                int resultModulo3 = n % 3;
                int resultModulo5 = n % 5;

                if (resultModulo3 == 0 || resultModulo5 == 0)
                {
                    list[index] = n;
                    index++;
                }
                n++;
            }
            Console.WriteLine("Zahlen zwischen 1 und 30 welche durch 3 und/oder 5 ohne Rest teilbar sind: ");
            Console.WriteLine(string.Join(",", list.Take(index)));
        }
    }
}
