﻿

using NewProject13;
using System;

Console.WriteLine("  Witam w programie oceny pracownika XYZ");
Console.WriteLine("  ======================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("  Podaj kolejną ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

// Console.WriteLine(statistics.AveragLetter);
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($" MIN: {statistics.Min} ");
Console.WriteLine($" MAX: {statistics.Max}");
