using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class DistanceTechnique : ITechnique
    {
        public string TargetMissile { get; set; }
        public string TechniqueName { get; set; }

        public DistanceTechnique(string missileType, string techName)
        {
            TargetMissile = missileType;
            TechniqueName = techName;
        }
        public double CalculateChance()
        {
            int distance = UserInputValidator.CalculateDistance(1500, TargetMissile);
            if (distance == 1)
            {
                Console.WriteLine("Missile has 100 launch success rate");
                return 100;
            }
            return 100 - distance / 1500.0;
        }
        public double CalculateChance(int distance)
        {
            if (distance == -1)
                return CalculateChance();
            return 100 - distance / 1500.0;
        }
    }
}
