

using NewProject13;

var employee = new Employee("Marek", "Baniak");
employee.AddGrade("Tom");
employee.AddGrade("200");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($" MIN: {statistics.Min} ");
Console.WriteLine($" MAX: {statistics.Max}");
