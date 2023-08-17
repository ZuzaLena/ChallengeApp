
using System;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee

    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }


        //metoda, która dodaje punkty
        public void AddGrade(float grade)
        {
            //walidacja danych - czy zakres jest odpowiedni
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {   //sprawdzenie czy grade jest floatem i jeśli jest to odsyła do metody AddGrade, gdzie sprawdzany jest dodatkowo zakres
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        //Zadanie dzień 10
        public void AddGrade(long grade)
        {
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }
        public void AddGrade(ulong grade)
        {
            float ulongToFloat = (float)grade;
            this.AddGrade(ulongToFloat);
        }
        public void AddGrade(double grade)
        {
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }
        public void AddGrade(uint grade)
        {
            float uintToFloat = (float)grade;
            this.AddGrade(uintToFloat);
        }
        public void AddGrade(int grade)
        {
            float intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }
        public void AddGrade(decimal grade)
        {
            decimal decimalRoundUp = Math.Ceiling(grade);
            float decimalToFloat = (float)decimalRoundUp;
            this.AddGrade((float)decimalToFloat);
        }


        //metoda, która będzie zwracać model Statistics
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                if(grade>=0)
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
                statistics.Sum += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            //statistics.Average /= this.grades.Count;


            return statistics;
        }
       
    }
}
