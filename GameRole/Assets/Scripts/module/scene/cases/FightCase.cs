using com.globals;
using com.net;
using module.scene.manager;
using module.scene.sceneUnit;
using module.scene.sceneUnit.avatar;
using module.scene.tile;
using proto;
using System;
using UnityEngine;

namespace module.scene.cases
{
    public class FightCase : BaseModule
    {
        private static FightCase _instance;

        public FightCase()
	    {
	    }

        public static FightCase getInstance()
        {
		    if (_instance == null) {
                _instance = new FightCase();
		    }
		    return _instance;
	    }

        private double myRoleID = 0; //我的ID

        override protected void initListeners() {
            addMessageListener(ModuleCommand.ENTER_GAME, onEnterGame);
			addSocketListener<m_fight_attack_toc>(SocketCommand.FIGHT_ATTACK, onFightWork);
		}

        private void onEnterGame(params object[] arg)
        {
            myRoleID = GlobalData.getInstance().getRoleID(); 
        }

        public void toFight(int sid = 1,double targetID = 0, int targetType = 0, Pt pt = null) {
			m_fight_attack_tos vo = new m_fight_attack_tos();
			vo.auto_hook = 0;
			vo.skillid = sid;
			vo.dir = UnitPool.getMyRole().curDir;
			vo.target_id = targetID;
			vo.target_type = targetType;
			if (targetID != 0) {
                SceneUnit unit = SceneUnitMgr.getUnit(targetID);
                vo.target_pos = unit.pos;
			}
			sendSocketMessage(vo);
		}

        private void onFightWork(m_fight_attack_toc vo)
        {
            throw new NotImplementedException();
        }

        public void onfight(m_fight_attack_toc vo) {
            bool isSelf = (vo.src_id == myRoleID || Math.Floor(vo.src_id / 100) * 100 == myRoleID); //代替vo.return_self
            showFightEffect(vo, isSelf);
        }

        private void showFightEffect(m_fight_attack_toc fightVO, bool isSelf) {
			Animal src = FightMgr.getSrc(fightVO); //施法者
			Animal[] dests = FightMgr.getDest(fightVO); //受创者数组
			excAction(fightVO, src, dests, isSelf);
            //excEffect(fightVO, src, dests, isSelf);
		}

        public void excAction(m_fight_attack_toc fightVO, Animal src, Animal[] dests, bool isSelf) {
            float curTime = Time.time;
			
			updateFightUnitPos(src,fightVO);
			if (src != null) {
				if (src is Monster) {
					//(src as Monster).delayAttackKey = LoopManager.setTimeout(attack, actionVO.delay * 33, [src, actionVO.type, fightVO.dir, fightVO.skillid, fightVO.target_id, isSelf]);
				} else {
                    string type = "attack";
                    attack(src, type, fightVO.dir, fightVO.skillid, fightVO.target_id, isSelf);
				}
			}			
		}

        //更正发起者位置
		private void updateFightUnitPos(SceneUnit src,m_fight_attack_toc fightVO){
			if (src != null && fightVO.src_pos > 0) { //更正发起者位置
                Vector3 pos = new Vector3();
                pos = TileUitls.getFlatCenterByPosWithVertor3(fightVO.src_pos,pos);
                src.resetPos(pos);
			}
		}

        private void attack(Animal tar,string attType,int dir,int skill,double targetID,bool needShake = true) {
			tar.attack(attType, dir);
		}
    }
}
