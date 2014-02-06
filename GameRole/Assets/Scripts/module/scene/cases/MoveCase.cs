using com.globals;
using com.net;
using module.scene.manager;
using module.scene.sceneUnit.avatar;
using module.scene.tile;
using module.scene.utils;
using proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module.scene.cases
{
    public class MoveCase : BaseModule
    {
        private static MoveCase _instance;

        public MoveCase()
	    {
	    }

        public static MoveCase getInstance()
        {
		    if (_instance == null) {
                _instance = new MoveCase();
		    }
		    return _instance;
	    }

        override protected void initListeners()
        {
            addSocketListener<m_move_walk_path_toc>(SocketCommand.MOVE_WALK_PATH, onWalkPath); //人物走路
        }

        public void onWalkPath(m_move_walk_path_toc vo) {
			if (vo.roleid == GlobalData.getInstance().user.base2.role_id) {
				return;
			}
			if (vo.walk_path == null || vo.walk_path.Length == 0) {
				// 错误：moveCase收到一条空路径";
				return;
			}
			//vo.walk_path = ConvertMath.walkPath_pt(vo.walk_path);
			Role role = SceneUnitMgr.getUnit(vo.roleid) as Role;
			if (role != null) {
                role.runToPath(vo.walk_path);
			}
		}
    }
}
