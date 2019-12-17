using System;
using Xunit;

namespace GradeBook.Tests
{

  //DELAGATES
  public delegate string WriteLogDelegate(string logMessage);
  public class TypeTests
  {

    int count = 0;

    [Fact]
    public void WriteLogDelegateCanPointToMethod()
    {
      WriteLogDelegate log = ReturnMessage;
      log += ReturnMessage;
      log += IncrementCount;

      var result = log("Hi!");
      Assert.Equal(3, count);
    }
    string IncrementCount(string message)
    {
      count++;
      return message;
    }
    string ReturnMessage(string message)
    {
      count++;
      return message;
    }


    [Fact]
    public void Test1()
    {
      var x = GetInt();
      SetInt(ref x);
      Assert.Equal(42, x);
    }

    private void SetInt(ref int x)
    {
      x = 42;
    }

    private int GetInt()
    {
      return 3;
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
      //arrange
      var book1 = GetBook("Book 1");
      GetBookSetName(out book1, "Lots of Money sounds good");
      //act
      //assert
      Assert.Equal("Lots of Money sounds good", book1.Name);
    }
    private void GetBookSetName(out InMemoryBook book, string name)
    {
      book = new InMemoryBook(name);
    }

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

    private void SetName(InMemoryBook book, string name)
    {
      book.Name = name;
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
      string name = "Bridger";
      var upper = MakeUpperCase(name);

      Assert.Equal("Bridger", name);
      Assert.Equal("BRIDGER", upper);
    }

    private string MakeUpperCase(string parameter)
    {
      return parameter.ToUpper();
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
    InMemoryBook GetBook(string name)
    {
      return new InMemoryBook(name);
    }
  }
}
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


/*Unit test are usually broken up in to three parts:
1. Arrange- Where the data being testing is arranged
2. The ACT section where the computation is carried out. this is the section that produces a result.
3.Last is the ASSERT section where a theory or a expected result would be ASSERTED

testing

Reference types are things like integers and strings.

or an example of a reference type is 

***   public class Person
      {

      }
****

value types are variables that hold a value like 

var x = 12;

DAY TO DAY CODING 
when building classes that is when one will be usually be making reference types.

You cannot change the value of a string only pass on a copy of it that changes. using a ToUpper method does not CHANGE the value of the string only makes a copy of it and passes the copy along.
-------------------------------------------------------------
REFERENCE TYPE =
var b = new Book("Grades");

VALUE TYPE = 
var x = 3;
 */

#endregion
