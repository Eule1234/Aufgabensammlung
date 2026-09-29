using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe14_Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welches Jahr möchtest du prüfen ob es sich um ein Schaltjahr handelt? ");
            string input2 = Console.ReadLine();
            int input = int.Parse(input2);

            string ergebnis = "";
            while (input2 != "q")
            {
                try
                {
                    if(input % 4 == 0 && input % 100 != 0)
                    {
                        ergebnis = input2 + "ist ein Schaltjahr.";
                    }
                    else if (input % 400 == 0)
                    {
                        ergebnis = input2 + "ist ein Schaltjahr.";
                    }
                    else
                    {
                        ergebnis = input2 + "ist KEIN Schaltjahr.";
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine($"Das Ergebnis ist:{ergebnis}");

                Console.Write("Welches Jahr möchtest du prüfen ob es sich um ein Schaltjahr handelt? (or q to quit) ");
                input2 = Console.ReadLine();

                if (int.TryParse(input2, out input))
                {
                    break;
                }

                if (input2 == "q" || input2 == "Q")
                {
                    break;
                }
            }
            
        }
    }
}
