using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public class LauncherMenuRunner
    {
        public static void RunLauncherMainMenu(LauncherMenuOptions LaunOptions)
        {
            Dictionary<int, Option> MainDict = new Dictionary<int, Option>()
            {
                {1, new Option(LaunOptions.AddMissle, "Store new missile\\s") } , {2, new Option(LaunOptions.ShowLaunchMenu, "Launch missile\\s") } ,
                {3, new Option(LaunOptions.ShowReport, "Inventory report") } , {4, new Option(LaunOptions.RemoveMissile, "Clean out missiles") } ,
                {5, new Option(LaunOptions.ExitSystem, "Shutdown the S6ML") }
            };
            (new NumericMenu(MainDict, $"{LaunOptions.LaunController.Launcher.Name} Menu", "Welcome to Shayetet-6s Missile Launcher, Commander", true, false)).Run();
        }
        public static void LaunchMissilesMenu(LauncherMenuOptions LaunOptions)
        {
            Dictionary<string, Option> MainDict = new Dictionary<string, Option>()
            {
                {"TotalWar", new Option(LaunOptions.TotalWar, "Launch all missiles") } , {"Choose", new Option(LaunOptions.LaunchMissiles, "Choose missiles to launch") } ,
            };
            (new StringMenu(MainDict, $"{LaunOptions.LaunController.Launcher.Name} Menu", "Welcome to Shayetet-6s Missile Launcher, Commander", true)).Run();
        }

        public static void ShowTechniquesMenu(MissileLauncher missileLauncher)
        {
            Console.WriteLine("Please choose on of the following techniques:");
            foreach (var tech in missileLauncher.LaunchTechniques)
            {
                Console.WriteLine($"{tech.Key} - {tech.Value.TechniqueName} ({tech.Value.TargetMissile})");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your choice:");
        }
        public static void PrintMenuFromDict<T, K>(Dictionary<T,K> dict, string output)
        {
            Console.WriteLine(output);
            foreach (var tech in dict)
            {
                Console.WriteLine($"{tech.Key} - {tech.Value} ({tech.Value})");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your choice:");
        }
    }
}
