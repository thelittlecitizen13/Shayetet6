using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Cruise : Missile
    {
        public Cruise(string missileType, ITechnique launchTechnique) : base(launchTechnique)
        {
            MissileType = "Cruise";
        }
    }
}
