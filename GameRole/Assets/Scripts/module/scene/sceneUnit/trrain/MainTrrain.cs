using UnityEngine;
using System.Collections;

public class MainTrrain
{
    GameObject body;
    public void init()
    {
        body = MonoBehaviour.Instantiate(Resources.LoadAssetAtPath("Assets/prefabs/trrain/TerrainMain.prefab", typeof(GameObject))) as GameObject;
        //body = MonoBehaviour.Instantiate(Resources.LoadAssetAtPath("Assets/prefabs/trrain/TrrainNormal.prefab", typeof(GameObject))) as GameObject;
        //body = GameObject.CreatePrimitive(PrimitiveType.Cube);

       // body.AddComponent<Plane>();
        //body.AddComponent<MeshCollider>();
        //body.AddComponent<MeshRenderer>();
       // body.AddComponent("TestTrrain");
    }

}