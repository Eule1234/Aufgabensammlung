using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe18_AlterBerechnen
{
    internal class Program
    {
        static void Main()
        {
            int ageY;
            int ageM;
            int ageD;
            int ageW;

            Console.Write("Bitte gib dein Gebrtsdatum ein (xx.xx.xxxx): ");

            try
            {
                DateTime birthdate = DateTime.Parse(Console.ReadLine());


                DateTime today = DateTime.Today;

                DateTime birthdayThisYear = new DateTime(
                    today.Year,
                    birthdate.Month,
                    birthdate.Day
                );

                ageY = today.Year - birthdate.Year;

                if (birthdayThisYear > today)
                {
                    ageY--;
                }

                ageM = (today.Year - birthdate.Year) * 12
                 + today.Month - birthdate.Month;

                if (today.Day < birthdate.Day)
                {
                    ageM--;
                }

                TimeSpan diffrence = today - birthdate;
                ageD = diffrence.Days;

                ageW = ageD / 7;

                Console.WriteLine($"Alter in Jahren: {ageY}");
                Console.WriteLine($"Alter in Monaten: {ageM}");
                Console.WriteLine($"Alter in Wochen: {ageW}");
                Console.WriteLine($"Alter in Tagen: {ageD}");
            }
            catch (SystemException ex)
            {
                Console.WriteLine($"Ungültiges Datum. {ex.Message}");
            }
        }
    }
}
