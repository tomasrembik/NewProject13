

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
        this.grades.Add(grade);
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

