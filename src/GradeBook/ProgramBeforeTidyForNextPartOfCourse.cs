using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program1
    {
        // this is a method
        static void Main1(string[] args)
        {
            //need to initiate a new array or we get the error "use of unassighned local variable
            // double[] numbers = new double[3];
            // numbers[0] = 12.7;
            // numbers[1] = 13.7;
            // numbers[2] = 14.4;
            // var result = numbers[0];
            // result = result +numbers[1];
            // result = result + numbers[2];

            var numbers = new[] {23.3,23.6,12.6};
            // List<double> grades = new List<double>();
            var grades = new List<double>() {23.3,23.6,12.6};
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades){
                    result += number;
            } 

            var avaragemod = result / grades.Count;
            Console.WriteLine(result);
            Console.WriteLine($"The avargae grade is {avaragemod:N2}");

            // var result = numbers[0];
            // result += numbers[1];
            // var result = 0.0;
            // foreach(double number in numbers){
            //         result += number;
            // } 
           
           

            double x;  x = 34.1;
            double y = 54.2;
            var z = 10.3;

            double add = x + y;
            var resultadd = x + y + z;

            Console.WriteLine($"{x} {y} {z}");            
            Console.WriteLine(add);
            Console.WriteLine(resultadd);       

            // Console.WriteLine("Hello World!");

            // if(args.Length >0) {
            // Console.WriteLine("Hello " + args[0] + "!");
            // // Stirng interperlation
            // Console.WriteLine($"Hello {args[0]}!");
            // }
            // else {
            //     Console.WriteLine("you need an input!");
            // }
        }
    }
}
