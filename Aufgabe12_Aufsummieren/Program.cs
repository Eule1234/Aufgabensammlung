using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe12_Aufsummieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');

            int[] numbers = new int[inputArray.Length];


                for (int i = 0; i < inputArray.Length; i++)
                {
                    numbers[i] = int.Parse(inputArray[i]);
                }

                int[] result = SumUp(numbers);

                Console.WriteLine("Ergebnis:");

                foreach (int number in result)
                {
                    Console.Write(number + "-> ");
                }
            }

        
            
            static int[] SumUp(int[] arr)
        {
                //Rückgabe-Array initialisieren 
                int[] result = new int[arr.Length];

                //todo: Array "result" gemäss Aufgabenstellung mit den aufsummierten Werten füllen
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                    result[i] = sum;
                }
                return result;
            }
        }
    }

