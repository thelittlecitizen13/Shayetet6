using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public class LauncherMenuCreator
    {

        public static NumericMenu LauncherMainMenuCreator(LauncherMenuOptions LaunOptions)
        {
            Dictionary<int, Option> MainDict = new Dictionary<int, Option>()
            {
                {1, new Option(LaunOptions.AddMissle, "Store new missile\\s") } , {2, new Option(LaunOptions.LaunchMissiles, "Launch missile\\s") } ,
                {3, new Option(LaunOptions.ShowReport, "Inventory report") } , {4, new Option(LaunOptions.RemoveMissile, "Clean out missiles") } ,
                {5, new Option(LaunOptions.ExitSystem, "Shutdown the S6ML") }
            };
            return new NumericMenu(MainDict, "Shayetet-6 Main Menu", "Welcome to Shayetet-6s Missile Launcher, Commander", true, false);
        }
    }
}
