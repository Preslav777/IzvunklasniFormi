using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasniFormi
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            int n = int.Parse(Console.ReadLine());
            // Добавяне на ученици
            for (int i = 0; i < n; i++) 
            {
                HighSchoolStudent student = new HighSchoolStudent();
                student.InputData();
                school.AddStudent(student);
            }
           
            // Извеждане на всички ученици
            school.DisplayAllStudents();
            Console.WriteLine("------------------------------");
            // Търсене на ученик по име
            Console.Write("Въведете име на ученик за търсене: ");
            string name = Console.ReadLine();
            Student foundStudent = school.GetStudentByName(name);
            foundStudent?.DisplayData();
            Console.WriteLine();
            // Брой ученици в ЗИП и СИП
            Console.WriteLine($"Брой ученици в ЗИП: {school.CountZipStudents()}");
            Console.WriteLine($"Брой ученици в СИП: {school.CountSipStudents()}");
            Console.WriteLine();
            // Ученик с най-висок успех
            Student topStudent = school.GetTopStudent();
            Console.WriteLine("Ученик с най-висок успех:");
            topStudent?.DisplayData();
            Console.WriteLine();
            // Сортиране по успех
            school.SortStudentsByAverage();
            Console.WriteLine("Ученици сортирани по успех:");
            school.DisplayAllStudents();
            Console.WriteLine();
            // Записване във файл
            school.SaveToFile("students.txt");

            /*
            if (topStudent != null)
            {

            }
            */
        }
    }
}
