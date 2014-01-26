using com.net;
using module.scene.manager;
using module.scene.sceneUnit.avatar;
using module.scene.tile;
using module.scene.utils;
using module.scene.view;
using proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace module.scene.cases
{
    public class MonsterCase : BaseModule
    {
        private static MonsterCase _instance;
        private SceneView _view;
		public static Pt lastMonsterBornPos;
		public static List<int> prepareQuit = new List<int>(); //可以清除的怪物ID
        private static Dictionary<string, int> quitTimeOut = new Dictionary<string, int>(); //quit之后等待消失的怪物的timeOutKey

        public MonsterCase()
	    {
	    }

        public static MonsterCase getInstance()
        {
		    if (_instance == null) {
                _instance = new MonsterCase();
		    }
		    return _instance;
	    }

        override protected void initListeners()
        {
            addSocketListener<m_monster_enter_toc>(SocketCommand.MONSTER_ENTER, onEnter); //怪物进入
            addSocketListener<m_monster_walk_toc>(SocketCommand.MONSTER_WALK, onWalk); //怪物走路
            addSocketListener<m_monster_dead_toc>(SocketCommand.MONSTER_DEAD, onDead); //怪物死亡
            addSocketListener<m_monster_quit_toc>(SocketCommand.MONSTER_QUIT, onQuit); //怪物清除
        }

        public void onEnter(m_monster_enter_toc vo) {
			if (SceneDataManager.isGaming == false) {
				return; //忽略，切地图map_enter_toc之前，后台莫名发这消息过来
			}
			for (int i = 0; i < vo.monsters.Length; i++) {
				monsterEnter(vo.monsters[i] as p_map_monster);
			}
		}

		private void monsterEnter(p_map_monster vo) {
            
			int qIndex = prepareQuit.IndexOf(vo.monster_id);
			if (qIndex != -1) { //把此怪从删除列表里面删除
                prepareQuit.RemoveAt(qIndex);
			}
			clearQuitTimeOut(vo.monster_id);
			Monster monster = SceneUnitMgr.getUnit(vo.monster_id) as Monster;
			if (monster == null) {
				monster = UnitPool.getMonster();
				_view.addUnit(monster, vo.monster_id, vo.pos, vo, PosUtil.getDir(vo.pos));
			} else {
				monster.reset(vo);
                Vector3 v3 = new Vector3();
                v3 = TileUitls.getFlatCenterByPosWithVertor3(vo.pos,v3);
                monster.resetPos(v3);
			}
		}

        public void onWalk(m_monster_walk_toc vo) {
			if (SceneDataManager.isGaming == false) {
				return;
			}
			Monster monster = SceneUnitMgr.getUnit(vo.monster_id) as Monster;
			if (monster != null) {
                Vector3 v3 = new Vector3();
                v3 = TileUitls.getFlatCenterByPosWithVertor3(vo.pos, v3);
                v3.y = 1;
                v3.x = v3.x + SceneDataManager.mapOffsetX;
                v3.z = v3.z + SceneDataManager.mapOffsetZ;
                Debug.Log("怪物：" + vo.monster_id + "需走到：" + v3.ToString());
                monster.runToPoint(v3);
			}
		}

        public static void clearQuitTimeOut(int monsterID) {
			if (quitTimeOut.ContainsKey(monsterID+"") == true) {
				//LoopManager.clearTimeout(quitTimeOut[monsterID]);
                quitTimeOut.Remove(monsterID+"");
			}
		}

		public void onQuit(m_monster_quit_toc vo) {
			if (prepareQuit.IndexOf(vo.monsterid) == -1) { //添加到删除列表
				prepareQuit.Add(vo.monsterid);
			}
			Monster monster = SceneUnitMgr.monsterHash[vo.monsterid+""] as Monster;
			int timeOutKey=0;
			if (monster != null) {
                object[] obj = {vo};
				//timeOutKey = LoopManager.setTimeout(sendToRoleState, 1000, obj);
				quitTimeOut[monster.id+""] = timeOutKey;
			}
		}

		private void sendToRoleState(m_monster_quit_toc vo) {
			int qIndex = prepareQuit.IndexOf(vo.monsterid);
			if (qIndex != -1) { //只有在删除列表里面的怪才能删除,否则此怪已经重生
				prepareQuit.Remove(qIndex);
				clearQuitTimeOut(vo.monsterid);
				_view.removeUnit(vo.monsterid, SceneUnitType.MONSTER_TYPE);
			}
		}

		/**
		 * 怪物死亡
		 * @param vo
		 *
		 */
		public void onDead(m_monster_dead_toc vo) {
			Monster monster = SceneUnitMgr.getUnit(vo.monsterid) as Monster;
			if (monster != null) {
				monster.status = AvatarUtil.DEAD;
				return; //由战斗播放死亡效果
			}
		}
    }
}
