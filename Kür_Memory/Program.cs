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
            Print2DArray(GameState());
            aufdecken();

        }

        static void Memory()
        {
            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1', '☯', '☸', '✈', '❀' }, { '2', '❤', '✌', '☸', '✌' }, { '3', '❀', '❤', '☺', '✵' }, { '4', '✵', '☯', '☺', '✈' } };
        }

        static char[,] GameState()
        {
            char[,] cards = { { ' ', '1', '2', '3', '4' }, { '1', '?', '?', '?', '?' }, { '2', '?', '?', '?', '?' }, { '3', '?', '?', '?', '?' }, { '4', '?', '?', '?', '?' } };

            return cards;
        }

        static void aufdecken()
        {
            Console.WriteLine("Welche stellen möchtest du Aufdecken?");
            int input = int.Parse(Console.ReadLine());

            int[] digits = GetDigits(input);

            foreach (int digit in digits)
            {
                Console.WriteLine(digit);
            }
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
