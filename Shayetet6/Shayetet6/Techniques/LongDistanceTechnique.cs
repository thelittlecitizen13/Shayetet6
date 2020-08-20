using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class DistanceTechnique : ITechnique
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
            Console.WriteLine("Please enter the target`s distance:");
            int distance = UserInputValidator.ReadIntParser();
            if (distance == 0)
            {
                Console.WriteLine("Missile has 100 launch success rate");
                return 100;
            }
            return 100 - distance / 1500.0;
        }
    }
}
