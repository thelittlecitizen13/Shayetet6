using System;
using System.Collections.Generic;
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
            int currentAmountOfType = Launcher.MissileTypeCounter[MissileType];
            if (currentAmountOfType == 0)
            {
                Console.WriteLine("There are no missiles");
                return;
            }
            if (currentAmountOfType < amount)
            {
                Console.WriteLine($"There where only {currentAmountOfType} missiles from type {MissileType}.");
                Console.WriteLine($"All of them were launched!");
                RemoveMissilesFromInventory(MissileType, currentAmountOfType);
                Launcher.MissileTypeCounter[MissileType] = 0;
                return;
            }
            Console.WriteLine($"There where only {currentAmountOfType} missiles from type {MissileType}.");
            Console.WriteLine($"All of them were launched!");
            RemoveMissilesFromInventory(MissileType, amount);
            Launcher.MissileTypeCounter[MissileType] -= amount;
            return;
        }
        public void RemoveMissilesFromInventory(string MissileType, int amount)
        {
            int count = 0;
            foreach (var missile in Launcher.AllMissiles)
            {
                if (missile.MissileType == MissileType)
                {
                    count++;
                    Launcher.AllMissiles.Remove(missile);
                }
                if (count == amount)
                    return;
            }
        }
        public void ShowReport()
        {

        }
    }
}
