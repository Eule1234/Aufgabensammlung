using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe17_ArraySortieren
{
    internal class Program
    {
        static void Main()
        {
                Console.WriteLine("Geben Sie die zu sortierenden Ganzzahlen mit Leerzeichen getrennt ein:");
                string input = Console.ReadLine();
                string[] strings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int[] numbers = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                try
                {
                    numbers[i] = int.Parse(strings[i]);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ungültige Eingabe: {strings[i]}. Es werden Ganzzahlen mit Leerzeichen getrennt erwartet. {ex.Message}");
                    return;
                }
            }
            SortiereArray(numbers);

                foreach (int i in numbers)
                {
                    Console.Write(i + " ");
                }
        }
        private static void SortiereArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int hilfe = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = hilfe;
                    }
                }
            }// TODO: Das Array arr sortieren 
        }
    }
}
