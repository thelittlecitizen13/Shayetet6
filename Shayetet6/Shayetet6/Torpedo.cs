using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class Torpedo : Missile
    {
        public Torpedo(string missileType, double chance, int distance) : base(missileType, chance, distance)
        {

        }
    }
}
