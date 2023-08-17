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

