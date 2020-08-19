using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public abstract class Missile
    {
        public string MissileType{ get; protected set; }
        public bool IsFailed { get; protected set; }
        public int TechniqueChance { get; protected set; }
        public int Distance { get; set; }
        public Missile(int chance, int distance)
        {
            TechniqueChance = chance;
            IsFailed = false;
            Distance = distance;
        }
        public void Fail()
        {
            IsFailed = true;
        }
        public void ChangeTechnique(int chance)
        {
            TechniqueChance = chance;
        }
        public override string ToString()
        {
            return $"Missile Type: {MissileType} | Failed: {IsFailed} | Distance: {Distance} | Launch success rate: {TechniqueChance}%";
        }
        public void Launch()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            IsFailed = randomNumber > TechniqueChance;
        }

    }
}
