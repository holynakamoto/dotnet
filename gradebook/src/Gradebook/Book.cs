using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStatistics()
        {            
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
                       
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number / grades.Count;
            }
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");

        }
        private List<double> grades;
        private string name;
    }
}