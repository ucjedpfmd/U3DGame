using UnityEngine;
using System.Collections;

public class NPC
{

    // Use this for initialization
    GameObject body;
    void Awake()
    {

    }

    public void reset()
    {
        initBody();
    }

    void initBody()
    {
        //string str = "file:///E:/Project/U3D/GameRole/Assets/elements/unit/role/100001/role_100001.FBX";
        //WWW load = new WWW(str);
        //yield load;
        body = MonoBehaviour.Instantiate(Resources.LoadAssetAtPath("Assets/prefabs/role_100001.prefab", typeof(GameObject))) as GameObject;
        body.AddComponent<CapsuleCollider>();
        CapsuleCollider cap = body.GetComponent<CapsuleCollider>();
        cap.radius = 10;
        body.AddComponent("NPCBehaviour");
        
    }

    public void play(string act, string dir = null)
    {
        body.animation.Play();
    }

    public void resetPos(Vector3 pos)
    {
        body.transform.position = pos;
    }
}
