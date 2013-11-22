using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NPCModule : BaseModule 
{

    // Use this for initialization
    private NPCPanel panel;
    private static NPCModule instance;
    public static NPCModule getInstance()
    {
        if (instance == null)
        {
            instance = new NPCModule();
        }
        return instance;
    }

    public NPCModule()
    {
        Dispatcher.dispatch(ModuleCommand.OPEN_NPC_PANEL);
    }

    protected override void initListeners()
    {
        base.initListeners();
        addMessageListener(ModuleCommand.OPEN_NPC_PANEL, openPanel);
    }

    public void openPanel(params object[] arg)
    {
        if (panel == null)
        {
            panel = new NPCPanel();
            
        }
        panel.openPanel();
        Debug.Log("openPanel");
    }

    public void closePanel()
    {
        if (panel != null)
        {
            panel.closePanel();
            Debug.Log("closePanel");
        }    
    }
}
