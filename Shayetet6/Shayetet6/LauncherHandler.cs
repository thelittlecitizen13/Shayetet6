using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class LauncherHandler
    {
        public MissileLauncher Launcher { get; private set; }
        public LauncherHandler(MissileLauncher launcher)
        {
            Launcher = launcher;
        }

    }
}
