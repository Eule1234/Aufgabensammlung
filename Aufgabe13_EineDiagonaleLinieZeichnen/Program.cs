using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe13_EineDiagonaleLinieZeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] showDiagonal = Diagonal();

            for (int i = 0; i < showDiagonal.GetLength(0); i++)
            {
                for (int j = 0; j < showDiagonal.GetLength(1); j++)
                {
                    Console.Write(showDiagonal[i, j]);
                }
                Console.WriteLine();
            }
        }
        static string[,] Diagonal()
        {
            string[,] lines;
            Console.Write("Wie lange soll die linie sein: ");
            int input = int.Parse(Console.ReadLine());
            lines = new string[input, input];

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    lines[i, j] = ("*");


                    if (i == j)
                    {
                        lines[i,j] = "  ";
                    }
                }
            }
            return lines;
        }
    }
}