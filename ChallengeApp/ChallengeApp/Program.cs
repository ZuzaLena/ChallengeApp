using ChallengeApp;
using System.ComponentModel.Design;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("2000");
employee.AddGrade("Zuza");
employee.AddGrade("8");
employee.AddGrade(2);
employee.AddGrade((uint)6);
employee.AddGrade((double)96);
employee.AddGrade((long)2);
employee.AddGrade((ulong)3);
employee.AddGrade((decimal)4.10M);

var statistics = employee.GetStatistics();
Console.WriteLine($"{employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum: {statistics.Sum}");
