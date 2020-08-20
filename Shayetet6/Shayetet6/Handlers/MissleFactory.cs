using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    public static class MissileFactory
    {
        public static Missile CreateMissile(string missileType, ITechnique technique)
        {
            switch(missileType)
            {
                case "Torpedo":
                    return new Torpedo(missileType, technique);
                case "Cruise":
                    return new Cruise(missileType, technique) ;
                case "Balistic":
                    return new Balistic(missileType, technique);
                case "LongDistance":
                    return new LongDistance(missileType, technique);
                default:
                    return null;
            }
        }
        public static Missile CreateMissile(LauncherHandler LaunHandler)
        {
            string type = UserInputValidator.ReadMissileTypeName("Which Type of missile would you like to create?");
            LauncherMenuCreator.ShowTechniquesMenu(LaunHandler.Launcher);
            ITechnique tech = UserInputValidator.GetChoiceOfDictionary<int, ITechnique>(LaunHandler.Launcher.LaunchTechniques);
            while (tech.TargetMissile != type)
            {
                Console.WriteLine($"The technique does not fit to {type} missile, please choose the currect on:");
                tech = UserInputValidator.GetChoiceOfDictionary<int, ITechnique>(LaunHandler.Launcher.LaunchTechniques);
            }
            return CreateMissile(type, tech);
        }
        
    }
}
