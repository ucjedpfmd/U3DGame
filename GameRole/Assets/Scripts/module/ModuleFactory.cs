using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ModuleFactory
{
    public static void createModules()
    {
        SceneModule.getInstance();
        NPCModule.getInstance();
    }
}
