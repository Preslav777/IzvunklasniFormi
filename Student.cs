using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvunklasniFormi
{
   public abstract class Student
    {
        private string name;
        private int @class;
        private char section;
        private double lastYearAverage;
        private List<string> zip;
        private List<string> sip;

        // Свойства
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Class
        {
            get { return @class; }
            set { @class = value; }
        }

        public char Section
        {
            get { return section; }
            set { section = value; }
        }

        public double LastYearAverage
        {
            get { return lastYearAverage; }
            set { lastYearAverage = value; }
        }

        public List<string> Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public List<string> Sip
        {
            get { return sip; }
            set { sip = value; }
        }

        // Конструктор
        public Student()
        {
            zip = new List<string>();
            sip = new List<string>();
        }

        // Абстрактни методи
        public abstract void InputData();
        public abstract void DisplayData();
        public abstract double CalculateAverage();
    }
}
