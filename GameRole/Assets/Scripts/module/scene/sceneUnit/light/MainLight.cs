using UnityEngine;
using System.Collections;

public class MainLight
{
    GameObject body;
    public void init()
    {
        body = MonoBehaviour.Instantiate(Resources.LoadAssetAtPath("Assets/prefabs/light/MainLight.prefab", typeof(GameObject))) as GameObject;
    }
}