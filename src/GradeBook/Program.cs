using System;
using System.Collections.Generic;

namespace GradeBook
{
    //normally only one class per file
    
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Lance grade book");

            EnterGrade(book);

            // book.AddGrade(89.1);     
            // // Console.WriteLine(book.grades[0]);       
            // book.AddGrade(90.5);                    
            // book.AddGrade(14.5);           
            var stats = book.GetStaistics();
            book.ShowStaistics(stats);
        }

        private static void EnterGrade(Book book)
        {
            var done = false;
            while (!done){
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q"){
                    done = true;
                    continue; //why not break 
                }
                else{
                    try{
                        var grade = double.Parse(input);
                        book.AddGrade(grade);
                    }

                    catch (ArgumentException ex){
                        Console.WriteLine(ex.Message);
                    }

                    catch (FormatException ex){
                        Console.WriteLine(ex.Message);
                    }

                    finally{ // perticulerly useful for tidying up
                        Console.WriteLine("**");
                    }

                    // catch(Exception ex){
                    //     Console.WriteLine(ex.Message);
                    // }
                }
            }
        }
    }

   
}
