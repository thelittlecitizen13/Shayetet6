using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class Technique
    {
        public string TargetMissile { get; set; }
        public int LaunchSuccessChance { get; set; }
        public Technique(string missileType)
        {
            TargetMissile = missileType;
        }
    }
}
