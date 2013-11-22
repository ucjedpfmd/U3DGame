using UnityEngine;
using System.Collections;

public class NPCPanelBehaviour : MonoBehaviour {

	// Use this for initialization
    UITexture bg;
    UISprite bg2;
    Material mMat;
    void Awake()
    {
        
        StartCoroutine(load());
        UIAtlas asset = Resources.LoadAssetAtPath("Assets/NGUIPrefabs/module/npc/NPCPanelAtlas.prefab", typeof(UIAtlas)) as UIAtlas;
        //bg2 = NGUITools.AddSprite(gameObject,asset,)
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator load()
    {
        
        bg = NGUITools.AddWidget<UITexture>(gameObject);
        string url = "file://" + Application.dataPath + "/elements/unit/trrain/0.jpg";
        //Debug.Log("文件路径" + url);
        WWW www = new WWW(url);
        yield return www;
        mMat = new Material(Shader.Find("Unlit/Transparent Colored"));
        bg.material = mMat;
        mMat.mainTexture = www.texture;
        //bg.MakePixelPerfect();
    }
}
