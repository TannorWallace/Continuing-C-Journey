using System;
using System.Collections.Generic;

public class Band
{
  public string Name;
  public List<Musician> Musicians;
  public void Announce()
  {
    Console.WriteLine("Welcome " + Name + " to the Stage");
  }
  public void AddMusician()
  {
  }
}