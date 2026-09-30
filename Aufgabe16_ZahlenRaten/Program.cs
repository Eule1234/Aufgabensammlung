using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe16_ZahlenRaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tries = 1;
            int number;
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            bool guessed = false;

            Console.WriteLine("Errate die Zahl zwischen 1 und 100!");
            string input = "";

            while (guessed == false)
            {
                Console.Write("Deine Zahl: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    try
                    {
                        if (number < randomNumber)
                        {
                            Console.WriteLine("Die Zahl ist zu klein, versuche es erneut.");
                            tries++;
                            guessed = false;
                        }
                        else if (number > randomNumber)
                        {
                            Console.WriteLine("Die Zahl ist zu hoch, versuche es erneut.");
                            tries++;
                            guessed = false;
                        }
                        else
                        {
                            Console.WriteLine($"Die Zahl stimmt! Du hast {tries} Versuche benötigt.");

                            Console.Write("Möchtest du nochmal spielen? [y/n] ");
                            string answer = Console.ReadLine();

                            if (answer == "y" || answer == "Y")
                            {
                                guessed = false;
                                tries = 1;
                                randomNumber = random.Next(1, 100);
                            }
                            else
                            {
                                guessed = true;
                                break;
                            }
                        }
                    }
                    catch (System.FormatException ex)
                    {
                        Console.WriteLine($"Ungültige eingabe, es wird eine Ganzzahl erwartet. {ex.Message}");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Es wird eine Ganzzahl erwartet.");
                    break;
                }
            }
        }
    }
}
