using module.scene.sceneUnit.avatar;
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
namespace module.scene.cases
{
    using System;
    using proto;
    using module.scene.manager;
    using module.scene.tile;
    using module.scene.utils;
    using UnityEngine;
    using module.scene.sceneUnit;
    using module.scene.view;
    using com.net;
    using com.globals;
    using com.encrypt;
    public class MapCase : BaseModule
    {

        private static MapCase _instance;
	    public MapCase ()
	    {
	    }

	    public static MapCase getInstance(){
		    if (_instance == null) {
			    _instance = new MapCase();
		    }
		    return _instance;
	    }

        private SceneView view {
			get {return SceneModule.getInstance().getView();}
		}

        override protected void initListeners() {
			addSocketListener<m_map_enter_toc>(SocketCommand.MAP_ENTER, onEnter); //人物进地图
            addSocketListener<m_map_slice_enter_toc>(SocketCommand.MAP_SLICE_ENTER, onSliceEnter); //跨Slice
            addSocketListener<m_map_change_map_toc>(SocketCommand.MAP_CHANGE_MAP, onChangMap); //请求进地图返回

            ////////////////////////
        }

	    private bool _changingMap;
	    private int _changingId;
        private int _tarMapID;
        public double extra_id;
        public bool isFirstEnterMap = true;

	    public void toChangeMap(int mapid, int lineID = 0, int extraID = 0, int multiple = 0, bool teamMap = false) {
		    if (_changingMap)
				    return;
			    _changingMap = true;
			
			    m_map_change_map_tos vo = new m_map_change_map_tos();
			    vo.map_id = mapid;
			    vo.line_id = lineID;
			    vo.extra_id = extraID;
			    vo.multiple = multiple; //是否使用多倍奖励进入地图 0是正常， 1为多倍奖励模式
			    vo.team_map = teamMap;            
			    sendSocketMessage(vo);		
	    }

        protected void onChangMap(m_map_change_map_toc vo)
        {
			    _changingMap = false;
    //			GameTracer.traces("=========onChangeMap" + vo.map_id);
			    SceneDataManager.changeVo = vo;
			    if (vo.err_code == 0) {
				    SceneDataManager.isGaming = false;
				    GlobalData.getInstance().bornPoint = new Pt(PosUtil.getTx(vo.pos), 0, PosUtil.getTy(vo.pos));
                    _tarMapID = vo.map_id;
				    extra_id = vo.extra_id;
                    SceneDataManager.isGaming = true;
                    MapCase.getInstance().toEnter(_tarMapID, extra_id, vo.multiple, vo.line_id);
			    } else {
				    //UnitPool.getMyRole().resetUnderControl(true);
			    }
	    }

        private bool isFirstEnterTos = true;
        private bool _isOnEnter;
        public void toEnter(int mapid, double extraId = 0, int multiple = 0,int lineID=0){
        //			GameTracer.traces("=========toEnter" + mapid);
	        m_map_enter_tos vo = new m_map_enter_tos();
	        vo.map_id = mapid;
	        vo.extra_id = extraId;
	        vo.multiple = multiple;
	        vo.line_id = lineID;
	        sendSocketMessage(vo);
	        /////////////////
	        if (isFirstEnterTos == true) {
                EncryptCSharp.startEncrypt(); //开始协议加密
		        isFirstEnterTos = false;
	        }
        }

        protected void onEnter(m_map_enter_toc vo)
        {
			Debug.Log("=========onEnter" + vo.map_id);
			if (SceneDataManager.isGaming == false) {
				return; //地图没切换完毕，忽略此消息
			}
			_isOnEnter = true;
			if (vo.err_code == 0) {
				if (vo.return_self) { //自己进
					view.clear();
//					MonsterCase.lastMonsterBornPos = null;
//					FightCase.lockedTargetID = 0;
//					LoadingSetter.mapLoading(false);
					//MapTransition.mapLoading(false);
					//view.map.startLoadBlur();
					//SceneUnitSearcher.pickFailed = 0;
					SceneDataManager.lineID = vo.line_id;
					if (vo.role_map_info != null) {
						GlobalData.getInstance().campId = vo.role_map_info.camp_id;
					}
				}
				//逐步初始化，一个一个来
                int i;
				for (i = 0; i < vo.roles.Length; i++) {
					roleEnter(vo.roles[i] as p_map_role);
				}
				for (i = 0; i < vo.monsters.Length; i++) {
					monsterEnter(vo.monsters[i] as p_map_monster);
				}
				for (i = 0; i < vo.dropthings.Length; i++) {
					//dropThingEnter(vo.dropthings[i] as p_map_dropthing);
				}
				for (i = 0; i < vo.grafts.Length; i++) {
					//collectEnter(vo.grafts[i] as p_map_collect);
				}
				for (i = 0; i < vo.pets.Length; i++) {
					//onPetEnter(vo.pets[i] as p_map_pet);
				}
				for (i = 0; i < vo.trap_list.Length; i++) {
					//onTrapEnter(vo.trap_list[i] as p_map_trap);
				}
				if (vo.return_self) { //自己进
					MyRole myRole = UnitPool.getMyRole();
					Vector3 pos = TileUitls.getFlatCenterByPos(vo.role_map_info.pos);
					myRole.reset();
                    myRole.resetPos(pos);//先把位置移好再reset,不然XY是旧的slice是错的
                    view.addUnit(myRole, vo.role_map_info.role_id, vo.role_map_info.pos, vo.role_map_info);
					//view.visible = true;

//					FightCase.lockedTargetID = 0;
					if (isFirstEnterMap == true) { //发送第一次进入地图的VO
						//KeyUtil.getInstance().enabled = true;
						dispatch(ModuleCommand.ENTER_GAME);
					}
					//dispatch(ModuleCommand.CHANGE_MAP, SceneDataManager.mapData.map_id); //告诉别的模块我切地图了
					//this.dispatch(ModuleCommand.CHANGE_MAP_ROLE_READY);
//					makeTestRoles();
				} else {
					//BroadcastSelf.logger("有单位进入地图");这句只是为了调试
				}
			} else {
//				Alert.show(ErrorCode.getError(vo.err_code, vo.reason), "进入地图出错");
			}
			view.reset();
		}

        private void onSliceEnter(m_map_slice_enter_toc vo)
        {
            if (SceneDataManager.isGaming == false) {
				return;
			}
			/////////////////下面是退出的单位///////////////////////////
            int i = 0;
			for (i = 0; i < vo.del_roles.Length; i++) { //排除自己
				if ((double)vo.del_roles[i] != GlobalData.getInstance().user.base2.role_id) {
                    view.removeUnit((double)vo.del_roles[i]);
				}
			}
			for (i = 0; i < vo.del_monsters.Length; i++) {
                view.removeUnit((double)vo.del_monsters[i], SceneUnitType.MONSTER_TYPE);
			}
			/////////////////下面是进入的单位///////////////////////////
			for (i = 0; i < vo.roles.Length; i++) {
				roleEnter(vo.roles[i] as p_map_role);
			}
			for (i = 0; i < vo.monsters.Length; i++) {
				monsterEnter(vo.monsters[i] as p_map_monster);
			}
        }

		// enterType1、普通 2、冲锋,3复活，4，击退
		private void roleEnter(p_map_role vo) {
			if (vo.role_id == GlobalData.getInstance().user.base2.role_id) {
				return; //有时候包含自己，是后台的bug
			}
			Role role = SceneUnitMgr.getUnit(vo.role_id) as Role;
			if (role == null) {
				role = UnitPool.getRole();
				view.addUnit(role, vo.role_id,vo.pos, vo, PosUtil.getDir(vo.pos));
			} else {
                Vector3 v3 = TileUitls.getFlatCenterByPos(vo.pos);			
                role.resetPos(v3);
                role.reset(vo);
			}
		}

        private void monsterEnter(p_map_monster vo) {
			Monster monster = SceneUnitMgr.getUnit(vo.monster_id) as Monster;
			if (monster == null) {
				monster = UnitPool.getMonster();
                view.addUnit(monster, vo.monster_id, vo.pos, vo, PosUtil.getDir(vo.pos));
			} else {
                Vector3 v3 = TileUitls.getFlatCenterByPos(vo.pos);
                monster.resetPos(v3);
				monster.reset(vo);
			}
            object[] lastpath = vo.last_walk_path;
			if (vo.last_walk_path.Length > 0) {
				Pt[] path = ConvertMath.walkPath_pt(lastpath); //转成PT
				//monster.run(path);
			}
		}
    }
}

