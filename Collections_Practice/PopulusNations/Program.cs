using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;


namespace PopulusNations
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"C:\source\On_My_Own\Pluralsight\C_Sharp_PS_Lessons\Collections_Practice\PopulusNations.csv";
      CsvReader reader = new CsvReader(filePath);

      Country[] countries = reader.ReadFirstNCountries(10);
      foreach (Country country in countries)
      {
        System.Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
        //Null cannot be enumerated!
      }
    }
  }
}
