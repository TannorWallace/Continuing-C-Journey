using System;
using System.Collections.Generic;

namespace Console_Lessons_Methods
{
  public class Program
  {
    static void Main(string[] args)
    {

      List<Musician> Musicians = new List<Musician>();
      Musician musician = new Musician();

      Console.WriteLine("What is the name of your band?");
      Band band = new Band();
      band.Name = Console.ReadLine();

      Console.WriteLine("Who wants to be added to the band?");
      musician.Name = Console.ReadLine();
      Console.WriteLine("What instrument does " + musician.Name + " play?");
      musician.Instrument = Console.ReadLine();
      Musicians.Add(musician);


      System.Console.WriteLine("Type 'Add' to add a Musician.");
      System.Console.WriteLine("Type 'Announce' to announce the band.");
      System.Console.WriteLine("Type 'Quit' to the application");
      var repeat = false;
      while (repeat)
      {
        System.Console.WriteLine("Add, Announce, or Quit?");
        var action = Console.ReadLine();
        if (action == "Add")
        {
          band.AddMusician();
        }
        else if (action.StartsWith("Add"))
        {
          var arguments = action.Split(' ');
          if (arguments.Length == 3)
          {
            band.AddMusician(arguments[1], arguments[2]);
          }
          else
          {
            band.AddMusician();
          }
        }
        else if (action == "Announce")
        {
          band.Announce();
        }
        else if (action == "Quit")
        {
          break;
        }
        else
        {
          System.Console.WriteLine(action + " is not a valid command");
        }
      }
    }
  }
}
// Console.WriteLine("What is the name of your band?");

// Band band = new Band();
// band.Name = Console.ReadLine();
// band.Announce();


// Musician musician = new Musician { Name = "Guy 1", Instrument = "Guitar" };
//ARRAY OBJECTS
// Musician[] musicians = new Musician[2];
// musicians[0] = new Musician 
// musicians[1] = new Musician { Name = "Guy2", Instrument = "Keyboard" };
