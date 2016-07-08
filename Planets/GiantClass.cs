using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planets
{
    public class GiantPlanet : Planet, IHasMoons, IhasRings
    {
        private string _type;

        public void GaintPlanet()
        {
            throw new System.NotImplementedException();
        }

        public void HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public void HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}