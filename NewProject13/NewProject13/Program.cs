// zadanie 6

using NewProject13;

Employee user1 = new Employee("Tomek","Walków",19);
Employee user2 = new Employee("Andrej","Ticzkin",25);
Employee user3 = new Employee("Halina","Gałazka",28);


user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(7);
user1.AddScore(2);
user1.AddScore(9);

user2.AddScore(1);
user2.AddScore(7);
user2.AddScore(3);
user2.AddScore(5);
user2.AddScore(3);

user3.AddScore(7);
user3.AddScore(5);
user3.AddScore(8);
user3.AddScore(8);
user3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}

Console.WriteLine("Pracownik z najwyższą licząbą ocen to: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " (wiek = " + employeeWithMaxResult.Age + ")");
Console.WriteLine("Uzyskany wynik: " + maxResult);


