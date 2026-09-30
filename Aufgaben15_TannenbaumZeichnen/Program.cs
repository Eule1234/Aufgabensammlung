using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben15_TannenbaumZeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] showTrunk = Trunk();
            string[,] showCrone = Crone();

            int GesamteBreite = Math.Max(showTrunk.GetLength(1), showCrone.GetLength(1));
            // Krone

            int LeerzeichenKrone = (GesamteBreite - showCrone.GetLength(1)) / 2;

            for (int i = 0; i < showCrone.GetLength(0); i++)
            {
            
            
                for (int j = 0; j < LeerzeichenKrone; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < showCrone.GetLength(1); j++)
                {
                    Console.Write(showCrone[i, j]);
                }

                Console.WriteLine();
            }

            // Stamm
            for (int i = 0; i < showTrunk.GetLength(0); i++)
            {
                int Leerzeichen = (GesamteBreite - showTrunk.GetLength(1)) / 2;

                for (int j = 0; j < Leerzeichen; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < showTrunk.GetLength(1); j++)
                {
                    Console.Write(showTrunk[i, j]);
                }

                Console.WriteLine();
            }
        }
        static string[,] Trunk()
        {
            string[,] linesTrunk;
            Console.Write("Wie lang soll der Stamm sein: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Wie breit soll der Stamm sein: ");
            int input2 = int.Parse(Console.ReadLine());
            linesTrunk = new string[input1, input2];

            for (int i = 0; i < linesTrunk.GetLength(0); i++)
            {
                for (int j = 0; j < linesTrunk.GetLength(1); j++)
                {
                    linesTrunk[i, j] = ("*");
                }
            }
            return linesTrunk;
        }


        static string[,] Crone()
        {
            string[,] lines;
            Console.Write("Wie hoch soll die Baumkrone sein: ");
            int input = int.Parse(Console.ReadLine());
            lines = new string[input, input * 2 - 1];

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    int Leerzeichen = input - 1 - i;
                    int Sternchen = (2 * i) + 1;

                    if (j < Leerzeichen)
                    {
                        lines[i, j] = (" ");
                    }
                    else if (j < (Leerzeichen + Sternchen))
                    {
                        lines[i, j] = ("*");
                    }
                    else
                    {
                        lines[i, j] = (" ");
                    }
                }
            }
            return lines;
        }
    }
}
