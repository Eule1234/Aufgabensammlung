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
            char[,] gamestate = GameState();

            string continiue = "y";

            while (continiue == "y" || continiue == "Y")
            {
                while (!IstSpielBeendet(gamestate))
                {
                    Print2DArray(gamestate);
                    aufdecken(gamestate);
                }

                Console.Write("Super, du hast alle Karten aufgedeckt, möchtest du nochmal Spielen? (y/n)");
                continiue = Console.ReadLine();
            }
        }

        static char[,] Memory()
        {
            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1','☯','☸','✈','❀' }, { '2','❤','✌','☸','✌' }, { '3','❀','❤','☺','✵' }, { '4','✵','☯','☺','✈' } };
            return cards;
        }

        static char[,] GameState()
        {
            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1', '?', '?', '?', '?' }, { '2', '?', '?', '?', '?' }, { '3', '?', '?', '?', '?' }, { '4', '?', '?', '?', '?' } };

            return cards;
        }

        static void aufdecken(char[,] gamestate)
        {
            {
                Console.WriteLine("Welche stellen möchtest du Aufdecken?");
                int input = int.Parse(Console.ReadLine());

                int[] digits = GetDigits(input);
                char[,] memory = Memory();

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
