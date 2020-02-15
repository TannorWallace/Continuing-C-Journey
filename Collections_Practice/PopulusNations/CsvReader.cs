using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PopulusNations
{
  class CsvReader
  {
    private string _csvFilePath;
    public CsvReader(string csvFilePath)
    {
      this._csvFilePath = csvFilePath;
    }
    public Dictionary<string, Country> ReadAllCountries()
    {
      var countries = new Dictionary<string, Country>();

      using (StreamReader sr = new StreamReader(_csvFilePath))
      {
        //read header line
        sr.ReadLine();
        string csvLine;
        //the while loop reads CSVLINE until it returns Null. So as long as there is data in the CSV file it will keep reading data until it hits a line with out data.
        while ((csvLine = sr.ReadLine()) != null)
        {
          Country country = ReadCountryFromCsvLine(csvLine);
          countries.Add(country.Code, country);
        }
      }
      return countries;
    }
    //Below is the re-written ReadCountryFromCsvLine method from the Exercise files
    public Country ReadCountryFromCsvLine(string csvLine)
    {
      string[] parts = csvLine.Split(',');
      string name;
      string code;
      string region;
      string popText;
      //Switch statement is used to properly split up the country data and handle the exceptions
      switch (parts.Length)
      {
        case 4:
          name = parts[0];
          code = parts[1];
          region = parts[2];
          popText = parts[3];
          break;
        case 5:
          name = parts[0] + ", " + parts[1];
          name = name.Replace("\"", null).Trim();
          code = parts[2];
          region = parts[3];
          popText = parts[4];
          break;
        default:
          throw new Exception($"Can't parse country from csvLine: {csvLine}");
      }

      // TryParse leaves population=0 if can't parse
      // There is another way that the instructor said would fix the issue but it wouldnt help understand collections
      int.TryParse(popText, out int population);
      return new Country(name, code, region, population);
    }


  }
}