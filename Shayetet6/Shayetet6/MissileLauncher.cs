using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public abstract class MissileLauncher
    {
        public string Name { get; protected set; }
        public int Capacity{ get; protected set; }
        public int currentAmount { get; set; }
        public List<Missile> AllMissiles { get; set; }
        public Dictionary<string, int> MissileTypeCounter { get; set; }
        public Menu<int> LauncherMenu { get; set; }
        public LauncherHandler MyHandler { get; private set; }
        public MissileLauncher(string name, int capacity)
        {
            Name = name;
            AllMissiles = new List<Missile>();
            Capacity = capacity;
            currentAmount = 0;
            MissileTypeCounter = new Dictionary<string, int>();
            MyHandler = new LauncherHandler(this);
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
