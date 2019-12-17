using System;
using System.Collections.Generic;
using System.IO;
namespace GradeBook
{

  public delegate void GradeAddeddelegate(object sender, EventArgs args);
  public class NamedOject : object
  {
    public NamedOject(string name)
    {
      Name = name;
    }
    public string Name
    {
      get;
      set;
    }
  }
  public interface IBook
  {
    void AddGrade(double grade);
    Stats GetStats();
    string Name { get; }
    event GradeAddeddelegate GradeAdded;
  }

  public abstract class Book : NamedOject, IBook
  {
    public Book(string name) : base(name)
    {
    }
    public abstract event GradeAddeddelegate GradeAdded;
    public abstract void AddGrade(double grade);
    public abstract Stats GetStats();
  }
  public class DiskBook : Book
  {
    public DiskBook(string name) : base(name)
    {
    }

    public override event GradeAddeddelegate GradeAdded;

    public override void AddGrade(double grade)
    {
      using (var writer = File.AppendText($"{Name}.txt"))
      {
        writer.WriteLine(grade);
        if (GradeAdded != null)
        {
          GradeAdded(this, new EventArgs());
        }
      }

    }

    public override Stats GetStats()
    {
      var result = new Stats();

      using (var reader = File.OpenText($"{Name}.txt"))
      {
        var line = reader.ReadLine();
        while (line != null)
        {
          var number = double.Parse(line);
          result.Add(number);
          line = reader.ReadLine();
        }
      }
      return result;
    }
  }
  public class InMemoryBook : Book
  {
    public InMemoryBook(string name) : base(name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(char letter)
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
    public override void AddGrade(double grade)
    {
      if (grade <= 100 && grade >= 0)
      {
        grades.Add(grade);
        if (GradeAdded != null)
        {
          GradeAdded(this, new EventArgs());
        }
      }
      else
      {
        throw new ArgumentException($"Invaild {nameof(grade)}");
      }
    }
    public override event GradeAddeddelegate GradeAdded;
    public override Stats GetStats()
    {
      var result = new Stats();

      for (var index = 0; index < grades.Count; index++)
      {
        result.Add(grades[index]);


      }
      #region What is an AVG
      //ok remeber that an average is the total of the amount of scores divided by the amout of scores in the equasion
      #endregion


      return result;
    }
    private List<double> grades;

    #region 
    /*
    *Properties*

    */
    #endregion

    public const string CATEGORY = "Coding";

  }
}

#region  NOTES
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

*REMEMBER*
The only things that can be "Thrown" are exception objects!
*/

#region Method Overloading
/*
moving in to method overriding 
previous method name 
(public void AddLetterGrade(char letter))

the C# compiler looks at the method signatures rather than the return type

the methods can share names but not signatures
below there are two AddGrade methods. 
1. returns a char letter
2. returns a double.
   these wont conflict unless you add a third method that returns the same signature type
   i.e. 
   AddGrade(char letter) for a second time would cause errors.
*/
#endregion
#endregion

