using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      Country norway = new Country("Norway", "NOR", "Europe", 123456789);
      Country finland = new Country("Finland", "FIN", "Europe", 123456879);

      var countries = new Dictionary<string, Country>();
      countries.Add(norway.Code, norway);
      countries.Add(finland.Code, finland);

      foreach (var country in countries.Values)
      {
        System.Console.WriteLine(country.Name);
      }
    }
  }
}
