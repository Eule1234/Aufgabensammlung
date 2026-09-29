using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe8_VerboteneWörter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

            Console.Write("Dein Kommentar: ");
            string input = Console.ReadLine();
            string comment = input.ToLower();

            string[] words = comment.Split(' ');
            int count = 0;

            for (int b = 0; b < words.Length; b++)
            {
                for (int i = 0; i < forbiddenWords.Length; i++)
                {
                    if (words[b] == forbiddenWords[i])
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar");
            }
            else
            {
                Console.WriteLine($"Dein Kommentar enthält {count} verbotene Wörter");
                Console.WriteLine("Er wird nicht veröffentlicht");
            }
        }
    }
}
