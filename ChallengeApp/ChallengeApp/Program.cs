// Zadanie dnia szóstego
using ChallengeApp;

Employee emp1 = new Employee("Tytus", "Chmielewski", 15);
Employee emp2 = new Employee("Romek", "Nowak", 17);
Employee emp3 = new Employee("Atomek", "Kowalski", 16);

emp1.AddScore(1);
emp1.AddScore(5);
emp1.AddScore(3);
emp1.AddScore(7);
emp1.AddScore(4);

emp2.AddScore(8);
emp2.AddScore(8);
emp2.AddScore(5);
emp2.AddScore(9);
emp2.AddScore(6);

emp3.AddScore(4);
emp3.AddScore(7);
emp3.AddScore(2);
emp3.AddScore(6);
emp3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};

int maxResult = -1;
Employee empWithMaxResult = null;

foreach (var e in employees)
{
    if (e.Result > maxResult)
    {
        maxResult = e.Result;
        empWithMaxResult = e;
    }
}

Console.WriteLine("Najwięcej punktów ma "
    + empWithMaxResult.Name + " "
    + empWithMaxResult.Surname + " w wysokości "
    + empWithMaxResult.Result);

Console.ReadKey(); 

