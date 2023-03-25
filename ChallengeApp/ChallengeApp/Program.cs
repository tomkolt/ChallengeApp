using ChallengeApp;
using System;

Console.WriteLine("                 Witamy w Programie ChallengeApp do oceny Pracownik�w");
Console.WriteLine("==========================================================================================");
Console.WriteLine();
Console.WriteLine("Wci�nij \"1\", aby oceni� Pracownika w pami�ci programu lub \"2\", aby oceni� do pliku:");


var inputCase = Console.ReadLine();
if (inputCase == "1")
{
    var employee = new EmployeeInMemory("Tom", "Kolt", 34, 'M');

    employee.GradeAdded += EmployeeGradeAdded;
        void EmployeeGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano now� ocen�");
    }

    while (true)
    {
        Console.WriteLine("Podaj kolejn� ocen� dla Pracownika. W przypadku gdy chcesz sko�czy�, wci�nij \"q\":");
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
    Console.WriteLine("******************************************");
    Console.WriteLine("Poni�ej kilka danych dla oceny Pracownika:");
    Console.WriteLine($"AVG: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}
else if (inputCase == "2")
{
    var employee = new EmployeeInFile("Tom", "Kolt", 34, 'M');

    employee.GradeAdded += EmployeeGradeAdded;
    void EmployeeGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano now� ocen�");
    }

    while (true)
    {
        Console.WriteLine("Podaj kolejn� ocen� dla Pracownika. W przypadku gdy chcesz sko�czy�, wci�nij \"q\":");
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
    Console.WriteLine("******************************************");
    Console.WriteLine("Poni�ej kilka danych dla oceny Pracownika:");
    Console.WriteLine($"AVG: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}
else
{
    Console.WriteLine("Wybrano cyfr� spoza limitu. Do widzenia!!!");
}