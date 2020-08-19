using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public class LauncherHandler
    {
        public MissileLauncher Launcher { get; private set; }
        public LauncherMenuOptions LauncherOptions { get; private set; }
        public NumericMenu LauncherMenu { get; set; }
        public LauncherHandler(MissileLauncher ML)
        {
            Launcher = ML;
            LauncherOptions = new LauncherMenuOptions(this);
            LauncherMenu = LauncherMenuCreator.LauncherMainMenuCreator(LauncherOptions);
        }
        public void Run()
        {
            LauncherMenu.Run();
        }
        public void AddMissile(Missile m)
        {
            Launcher.Capacity++;
            Launcher.currentAmount++;
            Launcher.AllMissiles.Add(m);
            Launcher.MissileTypeCounter[m.MissileType]++;
            Console.WriteLine($"{m.MissileType} missile added successfully");
        }
        public void LaunchMissile()
        {
            string type = UserInputValidator.ReadMissileTypeName("Enter missile type to launch:");
            Console.WriteLine("Enter amount of missiles to launch");
            int amount = UserInputValidator.ReadIntParser();
            RemoveMissileChecker(type, amount);
        }
        public void RemoveMissileChecker(string MissileType, int amount)
        {
            int totalAmountOfType = Launcher.MissileTypeCounter[MissileType];
            if (totalAmountOfType == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There are no {MissileType} missiles to launch!");
                Console.ResetColor();
                return;
            }

            List<Missile> launchableMissiles = Launcher.AllMissiles.Where(mis => mis.IsFailed == true && mis.MissileType == MissileType).Take(amount).ToList();
            foreach (var missile in launchableMissiles)
            {
                Launcher.AllMissiles.Remove(missile);
            }

            if (launchableMissiles.Count < amount)
            {
                Console.WriteLine($"There where only {launchableMissiles.Count} launchable (not failed) missiles from type {MissileType}.");
                Console.WriteLine($"All of them were launched!");
                return;
            }
            Console.WriteLine($"{launchableMissiles.Count} missiles from type {MissileType} were launched.");
        }
        public void RemoveMissileFromInventory(Missile m)
        {

            Launcher.AllMissiles.Remove(m);
            Launcher.MissileTypeCounter[m.MissileType]--;
            Launcher.currentAmount--;
        }
        public void LaunchAllMissiles()
        {
            List<Missile> launchableMissiles = Launcher.AllMissiles.Where(mis => mis.IsFailed == true).ToList();
            int totalAmount = Launcher.currentAmount;
            foreach (var missile in launchableMissiles)
            { 
                RemoveMissileFromInventory(missile);
            }
            if (totalAmount > launchableMissiles.Count)
            {
                Console.WriteLine($"{launchableMissiles.Count} missiles were launched!");
                Console.WriteLine($"All other {totalAmount - launchableMissiles.Count} are failed missiles.");
            }
            else
            {
                Console.WriteLine($"all {totalAmount} missiles were launched!");
            }
        }
        public void ShowReport()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The are currently {Launcher.currentAmount} of missiles:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var missile in Launcher.AllMissiles)
            {
                Console.WriteLine(missile.ToString());
            }
            Console.ResetColor();
        }
    }
}
