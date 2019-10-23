using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Grade Book");
      book.AddGrade(96.7);
      book.AddGrade(74.7);
      book.AddGrade(89.2);
      book.ShowStats();

      #region dont need
      // var numbers = new[] { 98.9, 87.2, 77.7, 88.8, 99.9 };
      #endregion

      // List<double> grades = new List<double>() { 98.9, 87.2, 77.7, 88.8, 99.9 };
      // grades.Add(55.5);


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
