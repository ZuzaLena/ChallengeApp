
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

            //pętla do while (różnica od pętli for/foreach jest taka, że zawsze robi pierwszy obieg pętli
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                statistics.Sum += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            //metoda przejdzie tyle razy ile elementów jest w metodzie

            //pętla while - przed wejściem do pętli sprawdzany jest warunek. Może się więc ona nie wykonać
            //while (index < this.grades.count) ;
            //{
            //    statistics.max = math.max(statistics.max, this.grades[index]);
            //    statistics.min = math.min(statistics.min, this.grades[index]);
            //    statistics.average += this.grades[index];
            //    statistics.sum += this.grades[index];
            //    index++;
            //} 

            //sposoby przerwania pętli:
            //break
            //continue
            //go to - nie używać

            //foreach(var grade in this.grades)
            //{
            //    statistics.Max = Math.Max(statistics.Max, grade);
            //    statistics.Min = Math.Min(statistics.Min, grade);
            //    statistics.Average += grade;
            //    statistics.Sum += grade;
            //}

            statistics.Average = statistics.Average / this.grades.Count;
            //statistics.Average /= this.grades.Count;


            return statistics;
        }
       //Zadanie dzień 11
        public Statistics GetStatisticsWithForEach()
        {
            var statistics1 = new Statistics();

            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
                statistics1.Sum += grade;

            }
            statistics1.Average = statistics1.Average / this.grades.Count;
            return statistics1;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();

            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;


            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Average += this.grades[index];
                statistics2.Sum += this.grades[index];

            }
            statistics2.Average = statistics2.Average / this.grades.Count;
            return statistics2;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();

            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Average += this.grades[index];
                statistics3.Sum += this.grades[index];
                index++;

            } while (index < this.grades.Count);

            statistics3.Average = statistics3.Average / this.grades.Count;
            return statistics3;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();

            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Average += this.grades[index];
                statistics4.Sum += this.grades[index];
                index++;
            } 

            statistics4.Average = statistics4.Average / this.grades.Count;
            return statistics4;
        }
    }
}
