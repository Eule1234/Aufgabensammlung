using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe19_VokabelnZählen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Vokale = { 'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü', 'E', 'O', 'A', 'I', 'U', 'Ö', 'Ü', 'Ä' };

            Console.Write("Dein Kommentar: ");
            string input = Console.ReadLine();
            int total = 0;

            Dictionary<char, int> sub = new Dictionary<char, int>();

            foreach (char c in input.Where(char.IsLetter))
            {

                if (Vokale.Contains(c))
                {
                    total++;

                    if (sub.ContainsKey(c))
                    {
                        sub[c]++;
                    }
                    else
                    {
                        sub.Add(c, 1);
                    }
                }
            }

            Console.WriteLine($"Dein Text enthält total {total} Vokale.");
            foreach (var ele in sub)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }
        }
    }
}
