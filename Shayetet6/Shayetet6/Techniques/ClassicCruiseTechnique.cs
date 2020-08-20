using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class ClassicCruiseTechnique : ITechnique
    {
        public string TargetMissile { get; set; }
        public string TechniqueName { get; set; }

        public ClassicCruiseTechnique(string techName)
        {
            TargetMissile = "Cruise";
            TechniqueName = techName;
        }
        public double CalculateChance(int distance = -1)
        {
            return 20.0;
        }
    }
}
