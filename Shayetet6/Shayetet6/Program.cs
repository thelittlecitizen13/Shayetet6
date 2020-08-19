using System;
using System.Text;
using System.Collections.Generic;
using MenuBuilder;

namespace Shayetet6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Patriot patriotLauncher = new Patriot("Patriot", 6);
            LauncherHandler patroitHandler = new LauncherHandler(patriotLauncher);
            patroitHandler.Run();
        }
    }
}
