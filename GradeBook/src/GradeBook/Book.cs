using System;
using System.Collections.Generic;


namespace GradeBook
{
  #region NOTES
  /*
  when using an if statement make sure the logic is correct to evalute the whole statement in the case of && and || if the left hand side of the if statement evalutates to true the right hand side wont be evalutated at all. 

  if(grade <= 100 || grade >= 0)

  this logic will not run the entire statement 

  if(grade <= 100 && grade >= 0)

  this logic will
--------------------------------------------------------------
*REMEMBER*
  -do while loops always execute atleast once.
  -STRUCT always refers to a value type.
  */
  #endregion
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddLetterGrade(char letter)
    {
      switch (letter)
      {
        case 'A':
          AddGrade(90);
          break;
        case 'B':
          AddGrade(80);
          break;
        case 'C':
          AddGrade(70);
          break;
        case 'D':
          AddGrade(60);
          break;
        case 'F':
          AddGrade(50);
          break;
        default:
          AddGrade(0);
          break;
      }
    }
    public void AddGrade(double grade)
    {

      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
      }
      else
      {
        Console.WriteLine("Invalid Value");
      }
    }

    public Stats GetStats()
    {
      var result = new Stats();
      result.Average = 0.0;
      result.High = double.MinValue;
      //gotta watch those min/max names that got me for a while 
      result.Low = double.MaxValue;
      for (var index = 0; index < grades.Count; index++)
      {

        result.Low = Math.Min(grades[index], result.Low);
        result.High = Math.Max(grades[index], result.High);
        result.Average += grades[index];

      }

      #region What is an AVG

      //ok remeber that an average is the total of the amount of scores divided by the amout of scores in the equasion
      #endregion

      result.Average /= grades.Count;
      switch (result.Average)
      {
        case var d when d >= 90.0:
          result.Letter = 'A';
          break;
        case var d when d >= 80.0:
          result.Letter = 'B';
          break;
        case var d when d >= 70.0:
          result.Letter = 'C';
          break;
        case var d when d >= 60.0:
          result.Letter = 'D';
          break;
        default:
          result.Letter = 'F';
          break;
      }



      return result;
    }

    private List<double> grades;
    public string Name;

  }
}