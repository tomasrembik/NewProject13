

using NewProject13;
using System;

Console.WriteLine("  Witam w programie oceny pracownika XYZ");
Console.WriteLine("  ======================================");
Console.WriteLine();

//var employee = new Employee();

var employee = new EmployeeInFile("Tom", "Tomson");
employee.AddGrade(0.5f);
employee.AddGrade(4);
employee.AddGrade(3);
employee.AddGrade(12);


//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}
//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");