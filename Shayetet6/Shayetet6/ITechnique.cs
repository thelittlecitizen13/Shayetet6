using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    interface ITechnique
    {
        public string TargetMissile { get; set; }
        public double CalculateChance();
    }
}
