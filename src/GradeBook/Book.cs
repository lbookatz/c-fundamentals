using System;
using System.Collections.Generic;
using GradeBook;

public class Book
    {
        //this is called a field, can't use var as it has to be explicit
        //use CTRL . when cursor on List to creat using statement
        //List<double> grades = new List<double>();

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStaistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;

            // var highgrade = double.MinValue;            
            // var lowgrade = double.MaxValue;

            foreach(var grade in grades){
                    result.Average += grade;
                    result.high  = Math.Max(grade, result.high );                    
                    result.low = Math.Min(grade, result.low);
            } 
            result.Average /= grades.Count;

            return result;

            // Console.WriteLine($"The avargae grade is {result:N1}");
            // Console.WriteLine($"The highest grade is {result.high :N1}");
            // Console.WriteLine($"The lowest grade is {result.low:N1}");

        }

        public void ShowStaistics (Statistics stats) {
            
            Console.WriteLine($"The avargae grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.high :N1}");
            Console.WriteLine($"The lowest grade is {stats.low:N1}");
        }
        private List<double> grades;
        private string name;
    }