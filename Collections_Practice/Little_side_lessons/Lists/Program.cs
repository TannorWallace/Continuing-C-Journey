using System;
using System.Collections.Generic;

namespace Lists
{
  class Program
  {
    static void Main(string[] args)
    {
      //Angle bracket notation denotes a generic type. This "<T>" lets you know that List<T> is an specified type. The T can be replaced for any data TYPE so depending on what data type goes in to the array you will provide "String", "INT", "DOUBLE", Yadda-Yadda INSTEAD of T.
      List<string> daysOfWeek = new List<string>();
      {
        daysOfWeek.Add("Monday");
        daysOfWeek.Add("Tuesday");
        daysOfWeek.Add("Wednesday");
        daysOfWeek.Add("Thursday");
        daysOfWeek.Add("Friday");
        daysOfWeek.Add("Saturday");
        daysOfWeek.Add("Sunday");

      };

    }
  }
}
