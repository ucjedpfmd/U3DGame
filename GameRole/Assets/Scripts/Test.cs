using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    void Awake()  {

    }
	// Use this for initialization
	void Start () {
        gameObject.AddComponent("MyRoleBehaviour");
        gameObject.AddComponent<MyRoleBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
