using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planets
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
		{
            _oxygen = oxygen;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }

        public bool Habitable()
        {
            if (_oxygen == true)
                return true;
            else
                return false;
        }

    }
}
