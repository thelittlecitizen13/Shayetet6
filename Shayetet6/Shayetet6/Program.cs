﻿using System;
using System.Text;
using System.Collections.Generic;
using MenuBuilder;
using Shayetet6.Techniques;

namespace Shayetet6
{
    class Program
    {
        static void Main(string[] args)
        {

            Patriot patriotLauncher = new Patriot("Patriot", 6);
            LauncherHandler patroitHandler = new LauncherHandler(patriotLauncher);
            ClassicTorpedoTechnique classicTorpedoTech = new ClassicTorpedoTechnique("Classic Torpedo Technique");
            ClassicCruiseTechnique classicCruiseTech = new ClassicCruiseTechnique("Classic Cruise Technique");
            ClassicBalisticTechnique classicBalisticTech = new ClassicBalisticTechnique("Classic Balistic Technique");
            DistanceTechnique longDistanceTech = new DistanceTechnique("LongDistance", "Distance Technique for LongDistance Missile");
            patroitHandler.AddTechnique(classicTorpedoTech);
            patroitHandler.AddTechnique(classicCruiseTech);
            patroitHandler.AddTechnique(classicBalisticTech);
            patroitHandler.AddTechnique(longDistanceTech);
            patroitHandler.Run();
        }
    }
}
