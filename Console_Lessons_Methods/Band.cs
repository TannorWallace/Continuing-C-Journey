using System;
using System.Collections.Generic;

public class Band
{
  public string Name;
  public List<Musician> Musicians;
  public void Announce()
  {
    Console.WriteLine("Welcome " + Name + " to the Stage");
    foreach (var musician in Musicians)
    {
      musician.Announce();
    }
  }
  public void AddMusician()
  {

    System.Console.WriteLine("What is the name of the musician to be added?");
    var name = Console.ReadLine();
    System.Console.WriteLine("What instrument does " + name + " play?");
    var instrument = Console.ReadLine();
    AddMusician(name, instrument);
  }
  public void AddMusician(string name, string instrument)
  {
    var musician = new Musician();
    System.Console.WriteLine("What is the name of the musician to be added?");
    musician.Name = Console.ReadLine();
    System.Console.WriteLine("What does " + musician.Name + " play?");
    musician.Instrument = Console.ReadLine();
    Musicians.Add(musician);
    System.Console.WriteLine(musician.Name + " was added.");
  }
}