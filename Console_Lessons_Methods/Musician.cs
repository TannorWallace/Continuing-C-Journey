using System;
using System.Collections.Generic;


public class Musician
{
  public string Name;
  public string Instrument;
  public void Announce()
  {
    Console.WriteLine(Name + " on the " + Instrument + "!");
  }

}