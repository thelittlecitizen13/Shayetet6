using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Torpedo : Missile
    {
        public Torpedo(string missileType, double chance, int distance) : base(chance, distance)
        {
            MissileType = "Torpedo";
        }
    }
}
