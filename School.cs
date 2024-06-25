using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasniFormi
{
    class School
    {
        private List<Student> students;

        public School()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayAllStudents()
        {
            students.ForEach(s => s.DisplayData());
        }

        public Student GetStudentByName(string name)
        {
            return students.First(s => s.Name == name);
        }

        public int CountZipStudents()
        {
            return students.Count(s => s.Zip.Any());
        }

        public int CountSipStudents()
        {
            return students.Count(s => s.Sip.Any());
        }

        public Student GetTopStudent()
        {
            return students.OrderByDescending(s => s.CalculateAverage()).First();
        }

        public void SortStudentsByAverage()
        {
            students = students.OrderBy(s => s.CalculateAverage()).ToList();
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Name},{student.Class},{student.Section},{student.LastYearAverage}");
                    // Запис на ЗИП и СИП
                    sw.WriteLine($"ЗИП: {string.Join(", ", student.Zip)}");
                    sw.WriteLine($"СИП: {string.Join(", ", student.Sip)}");
                }
            }
        }
    }
}
