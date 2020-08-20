using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Balistic : Missile
    {
        public Balistic(string missileType, ITechnique launchTechnique) : base(launchTechnique)
        {
            MissileType = "Balistic";
        }
    }
}
