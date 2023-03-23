using ChallengeApp;

Console.WriteLine("               Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("=========================================================================");
Console.WriteLine();
Console.WriteLine("Podaj oceny Pracownika, a w przypadku, gdy chcesz skoñczyæ, wciœnij \"q\"");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejn¹ ocenê Pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

