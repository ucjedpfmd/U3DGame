using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using module.scene.cases;

class ModuleFactory
{
    public static void createModules()
    {
        SceneModule.getInstance();
        NPCModule.getInstance();
        MapCase.getInstance();
        MonsterCase.getInstance();
    }
}
