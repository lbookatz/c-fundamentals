using System;
using System.Collections.Generic;
using GradeBook;


public class NamedObject{
    public NamedObject(String name ){
        Name = name;
    }
        public string Name {get;set;}
}
public abstract class Book : NamedObject
{
    public Book(string name) : base(name)
    {
    }

    public abstract void AddGrade(double grade);    
}
public class InMemoryBook : Book
    {
        //this is called a field, can't use var as it has to be explicit
        //use CTRL . when cursor on List to creat using statement
        //List<double> grades = new List<double>();

        public InMemoryBook(string name) : base(name)
        {            
            grades = new List<double>();
            this.Name = name;
        }

        public InMemoryBook(string name, string category) : base(name)
        {      
            this.category = category;    
            grades = new List<double>();
            this.Name = name;
        }

        // public void AddLetterGrade( Char letter)
        public void AddGrade( Char letter) // method overloading, looks at the method signature: name and paramaters and number of parameters.
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;                
            }
        }
        public override void AddGrade(double grade)
        {
            if( grade <= 100 && grade >= 0){
               grades.Add(grade);
            }
            else {
                // Console.WriteLine("invalid Value");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStaistics(){

            var result = new Statistics();
            result.Average = 0.0;
            result.high = double.MinValue;
            result.low = double.MaxValue;

            // var highgrade = double.MinValue;            
            // var lowgrade = double.MaxValue;

            //BREAK: leave loop , continue: start new loop iteration , goto: ...

            foreach(var grade in grades){
                    result.Average += grade;
                    result.high  = Math.Max(grade, result.high );                    
                    result.low = Math.Min(grade, result.low);
            } 
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.letter = 'B';
                    break;

                case var d when d >= 70.0:
                    result.letter = 'C';
                    break;

                case var d when d >= 60.0:
                    result.letter = 'D';
                    break;

                 default:
                    result.letter = 'F';
                    break;
            }

            return result;

            // Console.WriteLine($"The avargae grade is {result:N1}");
            // Console.WriteLine($"The highest grade is {result.high :N1}");
            // Console.WriteLine($"The lowest grade is {result.low:N1}");

        }

        public void ShowStaistics (Statistics stats) {
            Console.WriteLine($"For the book named");
            Console.WriteLine($"The avargae grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.high :N1}");
            Console.WriteLine($"The lowest grade is {stats.low:N1}");            
            Console.WriteLine($"The letter is {stats.letter:N1}");
        }
        public List<double> grades;

        // public string  Name
        // {
        //     get{return name;} //this is when someone wants to read 
        //     set{if(!string.IsNullOrEmpty(value)){name = value;}} //this is when someone wants to set
        // }
        // //public members by convention uppercase
        // private string name;
        //public string Name {get;set;} // only diffrence is reflection and seralization
        // another diffrence applying access modifiers
        //public string Name {get; private set;}

        readonly String category = "Science";

        public const String CATEGORY1 = "Science"; //ths cannot be changes anywhere // need to use class name to access Book.CATEGORY1
    }