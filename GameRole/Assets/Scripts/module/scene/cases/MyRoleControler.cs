using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using module.scene.sceneUnit.avatar;

class MyRoleControler
{
    public static bool isClickNPC;

	private static MyRoleControler _instance;
	
	public MyRoleControler() {
	}
	
	public static MyRoleControler getInstance() {
		if(_instance == null){
			_instance = new MyRoleControler();
		}
		return _instance;
	}

	public void onClickUnit(SceneUnit tar) {
		switch (tar.sceneType) {
		case SceneUnitType.MONSTER_TYPE:
			doMonsterClick(tar as Monster);
			break;
		}
	}

	private void doMonsterClick(Monster tar) {
		//FightCase.getInstance().toFight(GlobalData.getInstance().getCategory(), tar.id, SceneUnitType.MONSTER_TYPE);
	}
}
