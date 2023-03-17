

using NewProject13;

var employee = new Employee("Marek", "Baniak");
employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(8);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($" MIN: {statistics.Min} ");
Console.WriteLine($" MAX: {statistics.Max}");
