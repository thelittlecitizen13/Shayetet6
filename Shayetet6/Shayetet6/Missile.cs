using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public abstract class Missile
    {
        public string MissileType{ get; protected set; }
        public bool IsFailed { get; protected set; }
        public double TechniqueChance { get; protected set; }
        public int Distance { get; set; }
        public Missile(double chance, int distance)
        {
            TechniqueChance = chance
            IsFailed = false;
            Distance = distance;
        }
        public void Fail()
        {
            IsFailed = true;
        }
        public void ChangeTechnique(double chance)
        {
            TechniqueChance = chance;
        }

    }
}
