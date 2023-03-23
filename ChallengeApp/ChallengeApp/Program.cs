using ChallengeApp;

var employee = new Employee("Tom", "Kolt", 34);
employee.AddGrade("2");
employee.AddGrade("tom");
employee.AddGrade(2000);
employee.AddGrade(1.254654654654654465);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max}");
