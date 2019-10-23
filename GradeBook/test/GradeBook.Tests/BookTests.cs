using System;
using Xunit;



namespace GradeBook.Tests
{
  public class BookTests
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
    [Fact]
    public void Test1()
    {
      //arrange

      var book = new Book("");
      book.AddGrade(91.1);
      book.AddGrade(98.8);
      book.AddGrade(67.6);

      //act
      var result = book.GetStats();
      //assert
      Assert.Equal(85.8, result.Average, 1);
      Assert.Equal(98.8, result.High, 1);
      Assert.Equal(67.6, result.Low, 1);

    }
    #region NOTES
    /*Unit test are usually broken up in to three parts:
    1. Arrange- Where the data being testing is arranged
    2. The ACT section where the computation is carried out. this is the section that produces a result.
    3.Last is the ASSERT section where a theory or a expected result would be ASSERTED

testing
     */

    #endregion
  }
}
