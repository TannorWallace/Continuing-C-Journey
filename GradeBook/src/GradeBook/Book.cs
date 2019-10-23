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

    public Stats GetStats()
    {
      var result = new Stats();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach (var grade in grades)
      {

        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Average += grade;
      }
      #region What is an AVG

      //ok remeber that an average is the total of the amount of scores divided by the amout of scores in the equasion
      #endregion

      result.Average /= grades.Count;
      return result;
    }

    private List<double> grades;
    private string name;

  }
}