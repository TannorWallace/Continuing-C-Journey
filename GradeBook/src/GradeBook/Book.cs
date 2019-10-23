using System;
using System.Collections.Generic;


namespace GradeBook
{

  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStats()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MinValue;
      foreach (double number in grades)
      {

        lowGrade = Math.Min(number, lowGrade);
        highGrade = Math.Max(number, highGrade);
        result += number;
      }
      #region What is an AVG

      //ok remeber that an average is the total of the amount of scores divided by the amout of scores in the equasion
      #endregion

      result = result / grades.Count;
      System.Console.WriteLine($"The lowest grade is {lowGrade}");
      System.Console.WriteLine($"The highest grade is {highGrade}");
      System.Console.WriteLine($"The average grade is {result:N1}");
    }

    private List<double> grades;
    private string name;

  }
}