// Zadanie dnia dziewiątego
using ChallengeApp;

var emp = new Employee("Max", "Payne", 1975);
emp.AddScore(10);
emp.AddScore(20);
emp.AddScore(35);
emp.AddScore(15);
var statistics = emp.GetStatistics();

Console.WriteLine($"Max: { statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");

