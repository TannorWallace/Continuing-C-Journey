using System;
public class Band
{
  public string Name;
  public int Musicians;
  public void Announce()
  {
    Console.WriteLine("Welcome " + Name + " to the Stage");
  }
}