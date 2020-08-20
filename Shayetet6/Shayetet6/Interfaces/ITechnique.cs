using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public interface ITechnique
    {
        public string TechniqueName { get; set; }
        public string TargetMissile { get; set; }
        public double CalculateChance(int distance = -1);
    }
}
