﻿namespace ChallengeApp
{
    public class Employee : Person, IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age, char sex) : base(name, surname, age, sex)
        {

        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                switch (charResult)
                {
                    case 'A':
                    case 'a':
                        this.grades.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        this.grades.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        this.grades.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        this.grades.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wrong letter");
                }
            }
            else
            {
                throw new Exception("String is not a float");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
