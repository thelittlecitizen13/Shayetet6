using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LauncherMenuOptions
    {
        public LauncherHandler LaunHandler { get; private set; }
        public LauncherMenuOptions(LauncherHandler launcher)
        {
            LaunHandler = launcher;
        }
        public void ShowLaunchMenu()
        {
            LauncherMenuCreator.LaunchMissilesMenu(this).Run();
        }
        public void AddMissle()
        {
            LaunHandler.AddMissile(MissleFactory.CreateMissile());
        }
        public void TotalWar()
        {
            LaunHandler.LaunchAllMissiles();
        }
        public void LaunchMissiles()
        {
            LaunHandler.LaunchMissile();
        }
        public void ShowReport()
        {

        }
        public void RemoveMissile()
        {

        }
        public void ExitSystem()
        {

        }
    }
}
