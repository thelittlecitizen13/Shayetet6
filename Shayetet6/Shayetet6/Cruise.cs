﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class Cruise : Missile
    {
        public Cruise(string missileType, int chance, int distance) : base(chance, distance)
        {
            MissileType = "Cruise";
        }
    }
}
