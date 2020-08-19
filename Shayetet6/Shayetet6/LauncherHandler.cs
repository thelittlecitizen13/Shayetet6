using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public class LauncherHandler
    {
        public MissileLauncher Launcher { get; private set; }
        public LauncherHandler(MissileLauncher launcher)
        {
            Launcher = launcher;
        }
        public void AddMissle()
        {
            Launcher.AddMissile(MissleFactory.CreateMissile());
        }
        public void RemoveMissile()
        {

        }
        public void ShowReport()
        {

        }
        public void LaunchMissiles()
        {

        }
        public void ExitSystem()
        {

        }
    }
}
