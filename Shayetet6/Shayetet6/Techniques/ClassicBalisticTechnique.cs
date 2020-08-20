using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class ClassicBalisticTechnique : ITechnique
    {
        public string TargetMissile { get; set; }
        public string TechniqueName { get; set; }

        public ClassicBalisticTechnique(string techName)
        {
            TargetMissile = "Balistic";
            TechniqueName = techName;
        }
        public double CalculateChance()
        {
            return 50.0;
        }
    }
}
