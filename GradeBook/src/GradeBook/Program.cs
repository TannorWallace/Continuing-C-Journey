using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Grade Book");


      // var done = false;

      while (true)
      {
        Console.WriteLine("Please enter a grade or hit 'q' to exit...");
        var input = Console.ReadLine();
        if (input == "q")
        {
          break;
        }
        var grade = double.Parse(input);
        book.AddGrade(grade);
      }
      // book.AddGrade(96.7);
      // book.AddGrade(74.7);
      // book.AddGrade(89.2);


      var stats = book.GetStats();

      System.Console.WriteLine($"The lowest grade is {stats.Low}");
      System.Console.WriteLine($"The highest grade is {stats.High}");
      System.Console.WriteLine($"The average grade is {stats.Average:N1}");
      Console.WriteLine($"the Letter Grade is {stats.Letter}");

      #region dont need
      // var numbers = new[] { 98.9, 87.2, 77.7, 88.8, 99.9 };
      #endregion

      #region helloworld
      //   Console.Write(x + y / z);
      //   if (args.Length > 0)
      //   {
      //     Console.WriteLine($"Hello, {args[0]}!");

      //   }
      //   else
      //   {
      //     Console.WriteLine("Hi, fuck face!");
      //   }
      #endregion
    }
  }
}
