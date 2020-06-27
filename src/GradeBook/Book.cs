using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private string name;
        private List<double> grades;

        public Book(string name)
        {
            this.name = name;
            this.grades = new List<double>();
        }

        public void AddGrade(double grade) => grades.Add(grade);

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Average += grade;
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
            }

            result.Average /= grades.Count;

            return result;
        }
    }
}
