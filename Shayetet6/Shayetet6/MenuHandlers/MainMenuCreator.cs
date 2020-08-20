using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6.MenuHandlers
{
    class MainMenuCreator
    {
        private LauncherController[] launcherController;
        public MainMenuCreator(params LauncherController[] controllers)
        {
            launcherController = controllers;
            BuildMenu();
        }

        public void BuildMenu()
        {
            if (launcherController == null || launcherController.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No MissileLaunchers to manage!");
                Console.ResetColor();
                return;
            }
            Dictionary<int, Option> MainDict = new Dictionary<int, Option>();
            int count = 1;
            foreach(var controller in launcherController)
            {
                MainDict.Add(count, new Option(controller.Run, $"{controller.Launcher.Name} Menu"));
                count++;
            }
            (new NumericMenu(MainDict, "Shayetet-6 Main Menu", "Welcome to Shayetet-6s Missile Launcher Controller, Commander", true, false)).Run();
        }
    }
}
