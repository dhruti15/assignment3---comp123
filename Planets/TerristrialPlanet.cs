using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planets
{
    public class TerristrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public string TerrestialPlanet()
        {
            throw new System.NotImplementedException();
        }
    }
}