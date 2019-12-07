using System;
using System.Collections.Generic;
namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Grade Book");

      book.GradeAdded += OnGradeAdded;
      while (true)
      {
        Console.WriteLine("Please enter a grade or hit 'q' to exit...");
        var input = Console.ReadLine();
        if (input == "q")
        {
          break;
        }
        try
        {
          var grade = double.Parse(input);
          book.AddGrade(grade);
        }
        catch (ArgumentException ex)
        {
          System.Console.WriteLine(ex.Message);
          //throw;
        }
        catch (FormatException ex)
        {
          System.Console.WriteLine(ex.Message);
        }
        //this is if you want a block of code to ALWAYS execute
        finally
        {
          System.Console.WriteLine("I can do this! (determined!)");
        }
      }
      // book.AddGrade(96.7);
      // book.AddGrade(74.7);
      // book.AddGrade(89.2);
      var stats = book.GetStats();

      System.Console.WriteLine(Book.CATEGORY);
      System.Console.WriteLine($"For the book named {book.Name}");
      System.Console.WriteLine($"The lowest grade is {stats.Low}");
      System.Console.WriteLine($"The highest grade is {stats.High}");
      System.Console.WriteLine($"The average grade is {stats.Average:N1}");
      Console.WriteLine($"the Letter Grade is {stats.Letter}");

    }
    static void OnGradeAdded(object sender, EventArgs e)
    {
      System.Console.WriteLine("A grade was added");
    }

  }
}
