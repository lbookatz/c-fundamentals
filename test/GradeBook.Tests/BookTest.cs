using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {

            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);  
            book.AddGrade(77.3);

            var result = book.GetStaistics();

            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.high, 1);
            Assert.Equal(77.3, result.low, 1);

            // //arrange
            // var x =5;
            // var y = 2;
            
            // var expected = 7;

            // //act
            // var actual = x + y ;
            
            // // assert
            // Assert.Equal(expected,actual);
        }
    }
}
