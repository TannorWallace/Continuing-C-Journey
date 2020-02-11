using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace Collections
{
  class Program
  {
    //an array of the days of the week.
    static void Main(string[] args)
    {
      //string array daysOfWeek contains individual objects inbetween double qoutes ""
      string[] daysOfWeek = {
      "Monday",
      "Tuesday",
      "Wenesday", //to replaced this use daysOfWeek[2] = "Wednesday"; the square bracket syntax works to look up AND replaced items in an array!
      "Thursday",
      "Friday",
      "Saturday",
      "Sunday"
    };
      System.Console.WriteLine("Before");
      System.Console.WriteLine("------------");
      foreach (string day in daysOfWeek)
      {
        System.Console.WriteLine(day);
      }
      System.Console.WriteLine("");
      daysOfWeek[2] = "Wednesday";

      System.Console.WriteLine("\rAfter");
      System.Console.WriteLine("------------");
      foreach (string day in daysOfWeek)
      {
        System.Console.WriteLine(day);
      }


      //this string "chosenDay" is the ailised variable that the days of the week array feeds the selected day of the week in to. Arrays are ordered so you can always know the location of an item inside the array simply by its number. The order that the array follows is referred to the INDEX.

      /*When this code is run the selection of the days is off by one since the all OOP languages are ZERO indexed which meand that all collections are numbered from ZERO. So essentially ZERO is actually ONE and ONE is TWO and yadda yadda*/

      /*To use Human based indexing 1=1 2=2 yadda yadda simply change the iDay to iDay-1*/

      //these console.writelines display prompts to the screen asking for input and displaying that input back to the user.

      // System.Console.WriteLine("Which day of the week do you want to display?");
      // System.Console.WriteLine("(Monday = 1, etc.) > ");
      // int iDay = int.Parse(Console.ReadLine());
      // string chosenDay = daysOfWeek[iDay - 1];
      // System.Console.WriteLine($"That day is {chosenDay}");
    }
  }
}

