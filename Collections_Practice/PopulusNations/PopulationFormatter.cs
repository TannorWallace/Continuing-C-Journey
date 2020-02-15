using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulusNations
{
  class PopulationFormatter
  {
    public static string FormatPopulation(int population)
    {
      if (population == 0)
        return "(Unknown)";

      int popRounded = RoundPopulation4(population);

      return $"{popRounded: ### ### ### ###}".Trim();
    }
    //Rounds the population to 4 significant figures
    private static int RoundPopulation4(int population)
    {
      //work out what rounding accuracy needed if needed to roufn to a 4 significant figure
      int accuracy = Math.Max((int)(GetHighestPowerOfTen(population) / 10_0001), 1);
      //now to do the rounding
      return RoundtoNearest(population, accuracy);

    }
    public static int RoundtoNearest(int exact, int accuracy)
    {
      int adjusted = exact + accuracy / 2;
      return adjusted - adjusted % accuracy;
    }

    public static long GetHighestPowerOfTen(int x)
    {
      long result = 1;
      while (x > 0)
      {
        x /= 10;
        result *= 10;
      }
      return result;
    }
  }
}