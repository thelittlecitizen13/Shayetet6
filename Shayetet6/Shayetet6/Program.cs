using System;
using System.Text;
using System.Collections.Generic;
using MenuBuilder;
using Shayetet6.MenuHandlers;

namespace Shayetet6
{
    class Program
    {
        static void Main(string[] args)
        {
            LauncherController patroitHandler = CreatePatriot();
            MainMenuCreator mainMenu = new MainMenuCreator(patroitHandler);
        }

        public static LauncherController CreatePatriot()
        {
            Patriot patriotLauncher = new Patriot("Patriot", 6);
            LauncherController patroitHandler = new LauncherController(patriotLauncher);
            ClassicTorpedoTechnique classicTorpedoTech = new ClassicTorpedoTechnique("Classic Torpedo Technique");
            ClassicCruiseTechnique classicCruiseTech = new ClassicCruiseTechnique("Classic Cruise Technique");
            ClassicBalisticTechnique classicBalisticTech = new ClassicBalisticTechnique("Classic Balistic Technique");
            DistanceTechnique longDistanceTech = new DistanceTechnique("LongDistance", "Distance Technique for LongDistance Missile");
            patroitHandler.AddTechnique(classicTorpedoTech);
            patroitHandler.AddTechnique(classicCruiseTech);
            patroitHandler.AddTechnique(classicBalisticTech);
            patroitHandler.AddTechnique(longDistanceTech);
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Torpedo", classicTorpedoTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Cruise", classicCruiseTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Cruise", classicCruiseTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("LongDistance", longDistanceTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("LongDistance", longDistanceTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Balistic", classicBalisticTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Balistic", classicBalisticTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("LongDistance", longDistanceTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Cruise", classicCruiseTech));
            patroitHandler.AddMissile(MissileFactory.CreateMissile("Cruise", classicCruiseTech));
            return patroitHandler;
        }
    }
}
