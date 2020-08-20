﻿using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public abstract class MissileLauncher
    {
        public string Name { get;  set; }
        public int Capacity{ get;  set; }
        public int currentAmount { get; set; }
        public List<Missile> AllMissiles { get; set; }
        public Dictionary<string, int> MissileTypeCounter { get; set; }
        
        public MissileLauncher(string name, int capacity)
        {
            Name = name;
            AllMissiles = new List<Missile>();
            Capacity = capacity;
            currentAmount = 0;
            MissileTypeCounter = new Dictionary<string, int>();
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
