using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Henrique's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var result = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {result.Low}");
            Console.WriteLine($"The highest grade is {result.High}");
            Console.WriteLine($"The average grade is {result.Average:N1}"); // N (number), 1 (digit) of precision

            // var numbers = new[] { 12.5, 1.4 }; // Initialization

            

            
        }
    }
}
