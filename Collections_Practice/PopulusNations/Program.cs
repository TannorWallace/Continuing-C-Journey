﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulusNations
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"C:\source\On_My_Own\Pluralsight\C_Sharp_PS_Lessons\Collections_Practice\PopulusNations\PopulationByLRGST.csv";
      CsvReader reader = new CsvReader(filePath);
      Dictionary<string, Country> countries = reader.ReadAllCountries();

      Console.WriteLine("Which country code do you want to look up? ");
      string userInput = Console.ReadLine();

      bool gotCountry = countries.TryGetValue(userInput, out Country country);
      if (!gotCountry)
        Console.WriteLine($"Sorry, there is no country with code, {userInput}");
      else
        Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
    }
  }
}
