using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using proto;
using UnityEngine;
using module.scene.tile;
using module.scene.manager;

namespace module.scene.sceneUnit.avatar
{
    public class Role : Animal
    {
        private p_map_role _pvo;
        public Role()
        {
			init();
        }

		override protected void init(){
            myObj.name = "Role";
			avatar = new RichAvatar();
			avatar.setParent(myObj);
			sceneType = SceneUnitType.ROLE_TYPE;
		}

        override public void reset(object value = null)
        {
            _pvo = value as p_map_role;
            initBody();
        }

        private void initBody()
        {
			avatar.resetSkin(2,0);
            if (isInit == false)
            {
                myObj.AddComponent<CharacterController>();
                collider = myObj.AddComponent<MeshCollider>();
                LoopManager.addToFrame(this, loop);
                isInit = true;
            }       
        }

        override public void runToPoint(Vector3 v3) {
            point = v3;
            myObj.transform.LookAt(new Vector3(point.x, myObj.transform.position.y, point.z));
            SetGameAct(AvatarUtil.ACT_WALK);
        }

        public void runToPath(object[] path)
        {
            int lastPos = (int)path[path.Length-1];
            point = TileUitls.getFlatCenterByPosWithVertor3(lastPos, point);
            point.y = 1;
            point.x = point.x + SceneDataManager.mapOffsetX;
            point.z = point.z + SceneDataManager.mapOffsetZ;
            runToPoint(point);
        }
    }
}
