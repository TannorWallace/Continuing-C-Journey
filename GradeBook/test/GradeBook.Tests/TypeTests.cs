using System;
using Xunit;



namespace GradeBook.Tests
{
  public class TypeTests
  {
    #region NOTES
    /*fact is an attribute in C# fact attaches to Test1. 
    The unit test will look for methods that have the FACT attribute attached to them.

    when wanting to test a method "decorate" them with the [fact] attribute
    example.

    [fact]
    getNotableAstartes()
    {
        unit test will check the method run via the [fact] attribute
        USE* dotnet test to run unit test
    }
    */
    #endregion
    #region NOTES
    /*Unit test are usually broken up in to three parts:
    1. Arrange- Where the data being testing is arranged
    2. The ACT section where the computation is carried out. this is the section that produces a result.
    3.Last is the ASSERT section where a theory or a expected result would be ASSERTED

testing
     */

    #endregion

    [Fact]
    public void CansetNameFromREF()
    {
      //arrange
      var book1 = GetBook("Book 1");
      SetName(book1, "Big Book Of Mysteries");
      //act
      //assert
      Assert.Equal("Big Book Of Mysteries", book1.Name);


    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }

    [Fact]
    public void GetBookReturnsDifferentBooks()
    {
      //arrange
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      //act


      //assert
      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);

    }
    [Fact]
    public void TwoVARScanREFsameOBJ()
    {
      //arrange
      var book1 = GetBook("Book 1");
      var book2 = book1;

      //act


      //assert
      // Assert.Equal("Book 1", book1.Name);
      // Assert.Equal("Book 2", book2.Name);
      Assert.Same(book1, book2);

    }
    Book GetBook(string name)
    {
      return new Book(name);
    }
  }
}

