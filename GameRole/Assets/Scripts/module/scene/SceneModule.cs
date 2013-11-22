using UnityEngine;
using System.Collections;

public class SceneModule {

	// Use this for initialization
    private SceneView view;
	private static SceneModule instance;
	public static SceneModule getInstance() {
		if(instance == null){
			instance = new SceneModule();
		}
		return instance;
	}

    public SceneModule()
    {
        init();
    }
	
	private void init() {
        view = new SceneView();
        view.init();
	}

    public void resetMyRolePos(Vector3 pos)
    {
        view.resetMyRolePos(pos);
    }
}
