using ChallengeApp;

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
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"{employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum: {statistics.Sum}");

Console.WriteLine($"GetStatisticsWithForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Sum: {statistics1.Sum}");

Console.WriteLine($"GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Sum: {statistics2.Sum}");

Console.WriteLine($"GetStatisticsWithDoWhile");
Console.WriteLine($"average: {statistics3.Average:N2}");
Console.WriteLine($"max: {statistics3.Max}");
Console.WriteLine($"min: {statistics3.Min}");
Console.WriteLine($"sum: {statistics3.Sum}");

Console.WriteLine($"GetStatisticsWithWhile");
Console.WriteLine($"average: {statistics4.Average:N2}");
Console.WriteLine($"max: {statistics4.Max}");
Console.WriteLine($"min: {statistics4.Min}");
Console.WriteLine($"sum: {statistics4.Sum}");
