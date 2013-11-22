using UnityEngine;
using System.Collections;

public class MyRole {

	// Use this for initialization
	GameObject body;
    private static MyRole instance;
    public static MyRole getInstance()
    {
        if (instance == null)
        {
            instance = new MyRole();
        }
        return instance;
    }
	void Awake() {
		
	}
	
	public void reset() {
		initBody();
	}
	
	void initBody() {
		//string str = "file:///E:/Project/U3D/GameRole/Assets/elements/unit/role/100001/role_100001.FBX";
		//WWW load = new WWW(str);
		//yield load;
       // GameObject sour = Resources.LoadAssetAtPath("Assets/prefabs/role/3rd Person Controller.prefab", typeof(GameObject)) as GameObject;
        GameObject sour = Resources.LoadAssetAtPath("Assets/prefabs/role_100001.prefab", typeof(GameObject)) as GameObject;
        body = GameObject.Instantiate(sour) as GameObject;
        body.AddComponent("ThirdPersonCamera");
        body.AddComponent("MyRoleBehaviour");
        //body.transform.parent = xx;
        body.GetComponent<ThirdPersonCamera>().cameraTransform = GlobalData.camera.transform;
	}

    public void play(string act, string dir=null)
    {
        body.animation.Play(act);
    }
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void resetPos(Vector3 pos)
    {
        Debug.Log(pos);
        body.transform.position = pos;
    }

    public Vector3 pos()
    {
        return body.transform.position;
    }
}
