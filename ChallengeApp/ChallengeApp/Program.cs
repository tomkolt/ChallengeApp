using ChallengeApp;
using System.Numerics;

Employee employee1 = new Employee( "Tom", "Kolt", 34 );
Employee employee2 = new Employee( "Adam", "Kami", 33);
Employee employee3 = new Employee( "Ewelina", "Roch", 34);

employee1.AddScore(5);
employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(9);

employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(7);

employee3.AddScore(2);
employee3.AddScore(9);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1,  employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine($"Najwięcej punktów: {employeeWithMaxResult.Result}, zdobył(a): {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}, {employeeWithMaxResult.Age} lat(a).");