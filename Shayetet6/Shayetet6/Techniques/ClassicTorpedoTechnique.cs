using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class ClassicTorpedoTechnique : ITechnique
    {
        public string TargetMissile { get; set; }
        public string TechniqueName { get; set; }

        public ClassicTorpedoTechnique(string techName)
        {
            TargetMissile = "Torpedo";
            TechniqueName = techName;
        }
        public double CalculateChance(int distance = -1)
        {
            return 100.0;
        }
    }
}
