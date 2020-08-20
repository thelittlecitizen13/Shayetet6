using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public abstract class MissileLauncher
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int currentAmount { get; set; }
        public List<Missile> AllMissiles { get; set; }
        public Dictionary<string, int> MissileTypeCounter { get; set; }
        public Dictionary<int, ITechnique> LaunchTechniques { get; set; }

        public MissileLauncher(string name, int capacity)
        {
            Name = name;
            AllMissiles = new List<Missile>();
            Capacity = capacity;
            currentAmount = 0;
            MissileTypeCounter = new Dictionary<string, int>();
            LaunchTechniques = new Dictionary<int, ITechnique>();
            UpdateTypes();
        }
        protected void UpdateTypes()
        {
            foreach (string mType in Enum.GetNames(typeof(MissileTypes)))
            {
                if (!MissileTypeCounter.ContainsKey(mType))
                    MissileTypeCounter.Add(mType, 0);
            }
        }

    }
}
