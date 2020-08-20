using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public abstract class Missile
    {
        public string MissileType{ get; protected set; }
        public bool IsFailed { get; protected set; }
        public ITechnique LaunchTechnique { get; set; }
        public Missile(ITechnique launchTechnique)
        {
            IsFailed = false;
            LaunchTechnique = launchTechnique;
        }
        public void Fail()
        {
            IsFailed = true;
        }
        public void ChangeTechnique(ITechnique technique)
        {
            LaunchTechnique = technique;
        }
        public override string ToString()
        {
            return $"Missile Type: {MissileType} | Failed: {IsFailed} | Technique: {LaunchTechnique.TechniqueName}";
        }
        public void Launch()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            IsFailed = randomNumber > LaunchTechnique.CalculateChance();
        }
        public void Launch(int distance)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            IsFailed = randomNumber > LaunchTechnique.CalculateChance(distance);


        }

    }
}
