using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kür_Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string continiue = "y";
            Console.WriteLine("Memory -> Hinter den '? verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Zum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeile2Spalte2.");
            Console.WriteLine("Z.B.: 2142 deckt das Symbol in Zeile 2 und Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte2.");

            while (continiue == "y" || continiue == "Y")
            {
                char[,] gamestate = GameState();
                char[,] memory = Memory();
                int tries = 0;
                while (!IstSpielBeendet(gamestate))
                {
                    Print2DArray(gamestate);
                    aufdecken(gamestate, memory, ref tries);
                }

                Console.Write($"Super, du hast alle Karten in {tries} aufgedeckt, möchtest du nochmal Spielen? (y/n)");
                continiue = Console.ReadLine();
            }
        }

        static char[,] Memory()
        {
            List<char> symbols = new List<char>
            {
                '☯','☸','✈','❀',
                '❤','✌','☸','✌',
                '❀','❤','☺','✵',
                '✵','☯','☺','✈'
            };

            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1', '?', '?', '?', '?' }, { '2', '?', '?', '?', '?' }, { '3', '?', '?', '?', '?' }, { '4', '?', '?', '?', '?' } };

            Random random = new Random();

            for (int i = symbols.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                char temp = symbols[i];
                symbols[i] = symbols[j];
                symbols[j] = temp;
            }

            int index = 0;

            for (int i = 1; i < cards.GetLength(0); i++)
            {
                for (int j = 1; j < cards.GetLength(1); j++)
                {
                    cards[i, j] = symbols[index];
                    index++;
                }
            }

            return cards;
        }

        static char[,] GameState()
        {
            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1', '?', '?', '?', '?' }, { '2', '?', '?', '?', '?' }, { '3', '?', '?', '?', '?' }, { '4', '?', '?', '?', '?' } };

            return cards;
        }

        static void aufdecken(char[,] gamestate, char[,] memory, ref int tries)
        {
            {
                Console.WriteLine("Welche stellen möchtest du Aufdecken?");
                int input = int.Parse(Console.ReadLine());
                tries++;

                int[] digits = GetDigits(input);
                

                if (digits[0] == digits[2] && digits[1] == digits[3])
                {
                    Console.WriteLine("Ungültige Eingabe! 2x die gleiche Position.");
                    return;
                }
                else if (gamestate[digits[0], digits[1]] != '?' || gamestate[digits[2], digits[3]] != '?')
                {
                    Console.WriteLine("Ungültiger Versuch! An mindestens einer Position wurde das Symbol bereits aufgedeckt.");
                    return;
                }
                else
                {
                    gamestate[digits[0], digits[1]] = memory[digits[0], digits[1]];
                    gamestate[digits[2], digits[3]] = memory[digits[2], digits[3]];

                    char erstesSymbol = memory[digits[0], digits[1]];
                    char zweitesSymbol = memory[digits[2], digits[3]];

                    Print2DArray(gamestate);

                    if (erstesSymbol == zweitesSymbol)
                    {
                        Console.WriteLine("Du hast ein paar gefunden");
                        gamestate[digits[0], digits[1]] = ' ';
                        gamestate[digits[2], digits[3]] = ' ';
                    }
                    else
                    {
                        Console.WriteLine("Leider kein treffer.");
                        gamestate[digits[0], digits[1]] = '?';
                        gamestate[digits[2], digits[3]] = '?';
                    }
                    IstSpielBeendet(gamestate);
                }
            }
        }

        static bool IstSpielBeendet(char[,] gamestate)
        {
            for (int i = 1; i < gamestate.GetLength(0); i++)
            {
                for (int j = 1; j < gamestate.GetLength(1); j++)
                {
                    if (gamestate[i,j] == '?')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static int[] GetDigits(int input)
        {
            List<int> digits = new List<int>();

            while (input != 0)
            {
                digits.Add(input % 10);
                input = input / 10;
            }

            digits.Reverse();

            return digits.ToArray();
        }

        static void Print2DArray(char[,] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("[Leeres Array]");
                return;
            }

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
