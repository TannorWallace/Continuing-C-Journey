using System;
using System.Collections.Generic;

namespace Console_Lessons_Methods
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is the name of your band?");
      Band band = new Band();
      band.Name = Console.ReadLine();
      band.Announce();

      List<Musician> Musicians = new List<Musician>();
      Musicians.Add(new Musician { Name = "Guy1", Instrument = "Guitar" });
      Musicians.Add(new Musician { Name = "Guy2", Instrument = "KeyBoard" });
      Musicians.Add(new Musician { Name = "Guy3", Instrument = "Drums" });
      Musician musician = new Musician();
      Console.WriteLine("Who wants to be added to the band?");
      musician.Name = Console.ReadLine();
      Console.WriteLine("What instrument does " + musician.Name + " play?");
      musician.Instrument = Console.ReadLine();
      Musicians.Add(musician);
    }


  }
}

// Musician musician = new Musician { Name = "Guy 1", Instrument = "Guitar" };
//ARRAY OBJECTS
// Musician[] musicians = new Musician[2];
// musicians[0] = new Musician 
// musicians[1] = new Musician { Name = "Guy2", Instrument = "Keyboard" };
