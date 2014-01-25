using UnityEngine;
using System.Collections;
using module.scene.view;
using module;
using com.globals;
using module.scene.cases;
using module.scene.manager;

public class SceneModule : BaseModule{

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
        //init();
    }

    override protected void initListeners()
    {
        addMessageListener(ModuleCommand.START_UP_SCENE, onStartUpScene);
    }

    private void onStartUpScene(object obj) {
//			trace("startScene:" + getTimer());
		SceneDataManager.isGaming = true;
		int mapID = GlobalData.getInstance().user.pos.map_id;
		MapCase.getInstance().toEnter(mapID);
	}


    public void init()
    {
        view = new SceneView();
        view.init();
	}

    public SceneView getView()
    {
        return view;
	}

    public void resetMyRolePos(Vector3 pos)
    {
        view.resetMyRolePos(pos);
    }
}
