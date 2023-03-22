

namespace NewProject13
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            

        }
        public Employee(string name)
        {
            this.Name = name;
        }
            
        public string Name { get; private set; }
        public string Surname { get; private set; }
        

       public void AddGrade(float grade) 
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            { Console.WriteLine("Dane są nieprawidłowe");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades) 
            {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
                
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

    }
}

