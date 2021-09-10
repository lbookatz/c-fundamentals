using System;
using System.Collections.Generic;

namespace GradeBook
{
    //normally only one class per file
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Lance grade book");
            book.AddGrade(89.1);            
            book.AddGrade(90.5);                    
            book.AddGrade(14.5);            
            var stats = book.GetStaistics();
            book.ShowStaistics(stats);


        }
    }

   
}
