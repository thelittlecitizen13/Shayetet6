using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Torpedo : Missile
    {
        public Torpedo(string missileType, ITechnique launchTechnique) : base(launchTechnique)
        {
            MissileType = "Torpedo";
        }
    }
}
