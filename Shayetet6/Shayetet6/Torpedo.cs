using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Torpedo : Missile
    {
        public Torpedo(string missileType, int chance, int distance) : base(chance, distance)
        {
            MissileType = "Torpedo";
        }
    }
}
