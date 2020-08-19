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
        public Dictionary<Type, int> MissileTypeCounter { get; set; }
        public Menu<int> LauncherMenu { get; set; }
        public MissileLauncher(string name, int capacity)
        {
            Name = name;
            AllMissiles = new List<Missile>();
            Capacity = capacity;
            currentAmount = 0;
        }
        
    }
}
