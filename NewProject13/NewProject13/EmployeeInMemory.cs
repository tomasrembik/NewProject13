namespace NewProject13
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Dane są nieprawidłowe");

            }
        }

        public override void AddGrade(double grade)
        {
            float gradAsFloat = (float)grade;
            this.AddGrade(gradAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradesAsFlout = grade;
            this.AddGrade(gradesAsFlout);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }


            }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float");

            }
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
