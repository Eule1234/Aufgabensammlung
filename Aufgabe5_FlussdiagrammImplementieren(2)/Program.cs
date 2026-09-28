using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe5_FlussdiagrammImplementieren_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");

            string input = Console.ReadLine();
            int kilometers;

            if (int.TryParse(input, out kilometers) && kilometers >= 1)
            {
                if(kilometers > 42)
                {
                    Console.WriteLine("Das schaffst du nicht!");
                }
                else
                {
                    int kmInMeters = kilometers * 1000;
                    int amountRounds = kmInMeters / 400;

                    Console.WriteLine($"Das sind {amountRounds} Runden.");
                    Console.Write("Bist du bereit für den Lauf? (Ja/Nein) ");

                    string input2 = Console.ReadLine();
                    string answer = input2.ToLower();

                    bool result = false;

                    if (answer == "ja")
                    {
                        result = true;
                    }



                    if (result == true)
                    {
                        int i = 1;

                        while(i < amountRounds)
                        {
                            Console.WriteLine($"Du läufst Runde {i}");
                            i++;

                            Thread.Sleep(1000);
                        }
                        if (i == amountRounds)
                        {
                            Console.WriteLine("Du hast es geschafft!");
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Zahl im positiven Bereich erwartet");
            }
        }
    }
}
