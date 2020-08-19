using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public class LauncherMenuCreator
    {

        public static Menu<int> LauncherMainMenuCreator(LauncherHandler LaunHandler)
        {
            Dictionary<int, Option> MainDict = new Dictionary<int, Option>()
            {
                {1, new Option(LaunHandler.AddMissle, "Store new missile\\s") } , {2, new Option(LaunHandler.LaunchMissiles, "Launch missile\\s") } ,
                {3, new Option(LaunHandler.ShowReport, "Inventory report") } , {4, new Option(LaunHandler.RemoveMissile, "Clean out missiles") } ,
                {5, new Option(LaunHandler.AddMissle, "Shutdown the S6ML") }
            };
            return new NumericMenu(MainDict, "Shayetet-6 Main Menu", "Welcome to Shayetet-6s Missile Launcher, Commander", true, false);
        }
    }
}
