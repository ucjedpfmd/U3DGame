using UnityEngine;
using System.Collections;

public class TestTrrain : MonoBehaviour {

	// Use this for initialization
    GameObject body;
    bool isClose;
    void Awake()
    {
        
        StartCoroutine(load());
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator load()
    {
        
        MeshRenderer meshR = GetComponent("MeshRenderer") as MeshRenderer;
        string url = "file://" + Application.dataPath + "/elements/unit/trrain/0.jpg";
        Debug.Log("文件路径" + url);
        WWW www = new WWW(url);
        yield return www;
        meshR.material.mainTexture = www.texture;
    }

}
