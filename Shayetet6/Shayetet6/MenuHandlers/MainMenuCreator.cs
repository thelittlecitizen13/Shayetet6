using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6.MenuHandlers
{
    class MainMenuCreator
    {
        private LauncherHandler[] launcherHandlers;
        public MainMenuCreator(params LauncherHandler[] handlers)
        {
            launcherHandlers = handlers;
            BuildMenu();
        }

        public void BuildMenu()
        {
            if (launcherHandlers == null || launcherHandlers.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No MissileLaunchers to manage!");
                Console.ResetColor();
                return;
            }
            Dictionary<int, Option> MainDict = new Dictionary<int, Option>();
            int count = 1;
            foreach(var handler in launcherHandlers)
            {
                MainDict.Add(count, new Option(handler.Run, $"{handler.Launcher.Name} Menu"));
            }
            (new NumericMenu(MainDict, "Shayetet-6 Main Menu", "Welcome to Shayetet-6s Missile Launcher Controller, Commander", true, false)).Run();
        }
    }
}
