using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasniFormi
{
    class HighSchoolStudent : Student
    {
        public override void InputData()
        {
            try
            {
                // Метод за въвеждане на данни
                Console.Write("Име: ");
                Name = Console.ReadLine();
                Console.Write("Клас: ");
                Class = int.Parse(Console.ReadLine());
                Console.Write("Паралелка: ");
                Section = char.Parse(Console.ReadLine());
                Console.Write("Среден успех от предходната година: ");
                LastYearAverage = double.Parse(Console.ReadLine());
                // Въвеждане на ЗИП и СИП
                Console.WriteLine("Въведете ЗИП (разделени със запетая): ");
                Zip = Console.ReadLine().Split(',').ToList();
                Console.WriteLine("Въведете СИП (разделени със запетая): ");
                Sip = Console.ReadLine().Split(',').ToList();
            }

            catch (FormatException)
            {
                Console.WriteLine("Грешни данни! Опитай пак.");
                InputData();
            }
        }

        public override void DisplayData()
        {
            // Метод за извеждане на данни
            Console.WriteLine($"Име: {Name}, Клас: {Class}, Паралелка: {Section}, Среден успех: {LastYearAverage}");
            // Извеждане на ЗИП и СИП
            Console.WriteLine($"ЗИП: {string.Join(", ", Zip)}");
            Console.WriteLine($"СИП: {string.Join(", ", Sip)}");
        }

        public override double CalculateAverage()
        {
            // Връща среден успех
            return LastYearAverage;
        }
    }
}
