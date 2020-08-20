using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LauncherMenuOptions
    {
        public LauncherController LaunController { get; private set; }
        public LauncherMenuOptions(LauncherController launcher)
        {
            LaunController = launcher;
        }
        public void ShowLaunchMenu()
        {
            LauncherMenuRunner.LaunchMissilesMenu(this);
        }
        public void AddMissle()
        {
            Missile m = MissileFactory.CreateMissile(LaunController);
            LaunController.AddMissile(m);
        }
        public void TotalWar()
        {
            LaunController.LaunchAllMissiles();
        }
        public void LaunchMissiles()
        {
            LaunController.LaunchMissile();
        }
        public void ShowReport()
        {
            LaunController.ShowReport();
        }
        public void RemoveMissile()
        {
            LaunController.RemoveMissile();
        }
        public void ExitSystem()
        {

        }
    }
}
