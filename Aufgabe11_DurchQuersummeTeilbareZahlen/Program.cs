using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = BerechneTeilbarkeit();

            Console.WriteLine("========================================");
            Console.WriteLine("       ZAHLEN UND IHRE QUERSUMMEN");
            Console.WriteLine("========================================");

            Console.WriteLine("| {0,-5} | {1,-9} | {2,-16} |",
                "Zahl", "Quersumme", "Ergebnis");

            Console.WriteLine("|-------|-----------|------------------|");

            for (int i = 0; i < list.Length; i += 3)
            {
                Console.WriteLine("| {0,-5} | {1,-9} | {2,-16} |",
                    list[i], list[i + 1], list[i + 2]);
            }

            Console.WriteLine("========================================");
    }

        static int[] BerechneTeilbarkeit()
        {
            Console.WriteLine("Gib die erste Zahl ein: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Gib die zweite Zahl ein: ");
            int number2 = int.Parse(Console.ReadLine());

            int[] list = new int[0];

            while (number1 <= number2)
            {
                int sum = BerechneQuersumme(number1);

                if (sum != 0 && number1 % sum == 0)
                {
                    int number3 = number1 / sum;

                    Array.Resize(ref list, list.Length + 3);

                    list[list.Length - 3] = number1;
                    list[list.Length - 2] = sum;
                    list[list.Length - 1] = number3;
                }

                number1++;
            }

            return list;
        }

        static int BerechneQuersumme(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }