using ChallengeApp;

Console.WriteLine("            Witamy w Programie ChallengeApp do oceny Pracownik�w i Dyrekcji");
Console.WriteLine("==========================================================================================");
Console.WriteLine();
Console.WriteLine("Podaj oceny Pracownika lub Supervisiora, a w przypadku, gdy chcesz sko�czy�, wci�nij \"q\"");
Console.WriteLine();
Console.WriteLine("Wci�nij \"1\", aby oceni� Pracownika lub \"2\", aby oceni� Dyrektora");

var inputCase = Console.ReadLine();
if (inputCase == "1")
{
    var employee = new Employee("Tom", "Kolt", 34, 'M');

    while (true)
    {
        Console.WriteLine("Podaj kolejn� ocen� dla Pracownika:");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    var statistics = employee.GetStatistics();

    Console.WriteLine();
    Console.WriteLine("**********************************");
    Console.WriteLine("Poni�ej kilka danych dla oceny Pracownika:");
    Console.WriteLine($"AVG: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}
else if (inputCase == "2")
{
    var supervisor = new Supervisor("Tom", "Kolt", 34, 'M');

    while (true)
    {
        Console.WriteLine("Podaj kolejn� ocen� dla Dyrektora:");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    var statistics = supervisor.GetStatistics();

    Console.WriteLine();
    Console.WriteLine("**********************************");
    Console.WriteLine("Poni�ej kilka danych dla oceny Dyrektora:");
    Console.WriteLine($"AVG: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}
else
{
    Console.WriteLine("Wybrano cyfr� spoza limitu. Do widzenia!!!");
}
  



