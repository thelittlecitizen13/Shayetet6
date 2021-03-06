﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using MenuBuilder;

namespace Shayetet6
{
    public class LauncherController
    {
        public MissileLauncher Launcher { get; private set; }
        public LauncherMenuOptions LauncherOptions { get; private set; }
        public LauncherController(MissileLauncher ML)
        {
            Launcher = ML;
            LauncherOptions = new LauncherMenuOptions(this);
        }
        public void Run()
        {
            LauncherMenuRunner.RunLauncherMainMenu(LauncherOptions);
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
            LaunchissileChecker(type, amount);
        }
        public void LaunchissileChecker(string MissileType, int amount)
        {
            int totalAmountOfType = Launcher.MissileTypeCounter[MissileType];
            int successfulLaunches = 0;
            if (totalAmountOfType == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"There are no {MissileType} missiles to launch!");
                Console.ResetColor();
                return;
            }

            List<Missile> launchableMissiles = Launcher.AllMissiles.Where(mis => mis.IsFailed == false && mis.MissileType == MissileType).Take(amount).ToList();
            foreach (var missile in launchableMissiles)
            {
                missile.Launch();
                if (!missile.IsFailed)
                {
                    RemoveMissileFromInventory(missile);
                    successfulLaunches++;
                }
            }
            Console.WriteLine($"{successfulLaunches} successful launches from total of {launchableMissiles.Count} launchable missiles!");
        }
        public void RemoveMissileFromInventory(Missile m)
        {
            Launcher.AllMissiles.Remove(m);
            Launcher.MissileTypeCounter[m.MissileType]--;
            Launcher.currentAmount--;
        }
        public void LaunchAllMissiles()
        {
            int successfulLaunches = 0;
            List<Missile> launchableMissiles = Launcher.AllMissiles.Where(mis => mis.IsFailed == false).ToList();
            if (launchableMissiles.Count == 0)
            {
                Console.WriteLine("No missiles to launch.");
                return;
            }
            int totalAmount = Launcher.currentAmount;
            int distance = UserInputValidator.CalculateDistance(1500);
            foreach (var missile in launchableMissiles)
            {
                missile.Launch(distance);
                if (!missile.IsFailed)
                {
                    RemoveMissileFromInventory(missile);
                    successfulLaunches++;
                }
            }
            if (successfulLaunches > 0)
            {
                Console.WriteLine($"{successfulLaunches} missiles were launched!");
                Console.WriteLine($"All other {totalAmount - successfulLaunches} are failed missiles.");
            }
            else
                Console.WriteLine($"all {launchableMissiles.Count} launchable missiles were failed!");
        }
        public void ShowReport()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The are currently {Launcher.currentAmount} of missiles:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int count = 1;
            foreach (var missile in Launcher.AllMissiles)
            {
                Console.WriteLine($"{count} - {missile.ToString()}");
                count++;
            }
            Console.ResetColor();
        }
        public void RemoveMissile()
        {

            ShowReport();
            Console.WriteLine();
            Console.WriteLine("Enter the index of the missile which you would like to remove");
            int choice = UserInputValidator.ReadIntParser();
            try
            {
                Missile m = Launcher.AllMissiles[choice];
                RemoveMissileFromInventory(m);
            }
            catch
            {
                Console.WriteLine("No missile for this index");
            }
            
        }
        public void AddTechnique(ITechnique technique)
        {
            int lastDictKey;
            try
            {
                lastDictKey = Launcher.LaunchTechniques.Keys.Last();
                lastDictKey++;
            }
            catch (InvalidOperationException)
            {
                lastDictKey = 1;
            }
            Launcher.LaunchTechniques.Add(lastDictKey, technique);

        }
    }
}
