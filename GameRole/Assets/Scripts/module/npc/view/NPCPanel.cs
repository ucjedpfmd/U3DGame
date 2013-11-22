using UnityEngine;
using System.Collections;

class NPCPanel
{
    GameObject body;
    UITexture bg;

    public NPCPanel(){
        
        Object asset = Resources.LoadAssetAtPath("Assets/prefabs/module/npc/NPCPanel.prefab", typeof(GameObject));
        body = (GameObject)GameObject.Instantiate(asset);
        body.AddComponent("NPCPanelBehaviour");
        
        
        NGUIUtility.SetParent(body.transform);
    }

    public void openPanel()
    {
        if (body != null)
        {
            body.SetActive(true);
        }
    }

    public void closePanel()
    {
        if (body != null)
        {
            body.SetActive(false);
        }     
    }
}
