using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LongDistance : Missile
    {
        public LongDistance(string missileType, ITechnique launchTechnique) : base(launchTechnique)
        {
            MissileType = "LongDistance";
        }
    }
}
