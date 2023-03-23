using ChallengeApp;

Console.WriteLine("               Witamy w Programie ChallengeApp do oceny Pracowników");
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
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine("**********************************");
Console.WriteLine("Poni¿ej kilka danych:");
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

