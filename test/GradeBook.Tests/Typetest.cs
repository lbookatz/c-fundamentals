using System;
using Xunit;

namespace GradeBook.Tests
{


    public class TypeTests
    {

        [Fact]
        public void testingStrings()
        {
            string name = "Lance";
            name = name.ToUpper();

            Assert.Equal("LANCE", name);

        }

        [Fact]
        public void valuetypealsopassedbyref()
        {
            var x = GetInt();
            setInt(ref x);

            Assert.Equal(42,x);
        }

        private void setInt(ref int x)
        {
           x = 42;
        //    return x;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRefAndLooseData()
        {
            var book1 = GetBook("Book 1");
            
            book1.AddGrade(89.1);
            
            GetBookSetName(ref book1, "New Name");

            book1.AddGrade(23.5);

            Assert.Equal("New Name", book1.Name);
            Assert.Equal(23.5, book1.grades[0]);
        }

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }


         [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CanSetNameByRefrence()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name= name ;
        }

        [Fact]
        public void GetBookReturnsDiffrentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);
        }

        [Fact]
        public void TwoVarsCanREfrenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1,book2);
            Assert.True(object.ReferenceEquals(book1,book2));


            // Assert.Equal("Book 1", book1.Name);
            // Assert.Equal("Book 1", book2.Name);
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
