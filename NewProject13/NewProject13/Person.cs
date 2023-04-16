namespace NewProject13
{
    public abstract class Person
    {
        public Person()
        {
            
        }
        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            
        }
        public Person(string Name, string Surname, string Sex)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Sex = Sex;
        }
        public string Name { get;private set; }
        public string Surname { get;private set; }
        public string Sex { get;private set;}
    }
}
