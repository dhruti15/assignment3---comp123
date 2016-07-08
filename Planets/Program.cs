using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Program
    {
        public static void Main()
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 12345678, 1234567890, "Gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Pluto", 1234567, 12345678, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            Console.ReadKey();
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}



