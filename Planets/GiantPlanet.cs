using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planets
{
    public class GiantPlanet : Planet, IHasMoons, IhasRings
    {
        private string _type = "Gas";

        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }

    }
}

