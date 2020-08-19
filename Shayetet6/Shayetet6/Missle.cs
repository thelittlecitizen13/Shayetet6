using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public abstract class Missle
    {
        public string Name { get; protected set; }
        public bool IsFailed { get; protected set; }
        public double TechniqueChance { get; protected set; }
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
