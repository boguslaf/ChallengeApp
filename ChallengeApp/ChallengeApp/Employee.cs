using System.Net.NetworkInformation;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> scores = new List<float>();

        public Employee(string name, string surname, int yearOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.Year = yearOfBirth;
        }
        public void AddScore(float number)
        {
            this.scores.Add(number);
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in scores) 
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.scores.Count;

            return statistics;
        }
    }
}
