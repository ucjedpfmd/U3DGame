namespace module.scene.sceneUnit{
    using UnityEngine;
    using System.Collections;
    using AssemblyCSharp;
    using module.scene.sceneUnit.avatar;
    using com.globals;
    using proto;

    public class MyRole : Role
    {

        private p_map_role _pvo;
        private static MyRole instance;
        public static MyRole getInstance()
        {
            if (instance == null)
            {
                instance = new MyRole();
            }
            return instance;
        }

        public MyRole()
        {
			init();
        }

		override protected void init(){
            myObj.name = "MyRole";
			avatar = new RichAvatar();
			avatar.setParent(myObj);
			sceneType = SceneUnitType.ROLE_TYPE;
		}

        override public void reset(object value = null)
        {
            _pvo = value as p_map_role;
            //myObj.name = "MyRole" + _pvo.role_id;
            resetSkin(2, 0);
        }

        override public void resetSkin(int skinID, int sex)
        {
			avatar.resetSkin(skinID,sex);
			if(isInit == false){
				initScript();
                LoopManager.addToFrame(this, loop);
			}
            
        }

		private void initScript(){
            myObj.AddComponent<CharacterController>();
			SmoothFollow sf = GlobalData.camera.GetComponent("SmoothFollow") as SmoothFollow;
			sf.distance = 6;
			sf.height = 4;
			sf.target = avatar.body.transform;
			collider = myObj.AddComponent<MeshCollider>();
			isInit = true;
		}

        override public void play(string act, int dir = -1)
        {
            avatar.body.animation.Play(act);
        }

        public Vector3 pos()
        {
			return myObj.transform.position;
        }

        override public void runToPoint(Vector3 pointAft)
        {
            //目前场景中只有地形
            //其实应当在判断一下当前射线碰撞到的对象是否为地形。

            //得到在3D世界中点击的坐标
            pointAft.y = 1;
            point = pointAft;

            //设置主角面朝这个点，主角的X 与 Z轴不应当发生旋转，
            //注解1
            myObj.transform.LookAt(new Vector3(point.x, myObj.transform.position.y, point.z));

            //用户是否连续点击按钮
            if (Time.realtimeSinceStartup - time <= 0.2f)
            {
                //连续点击 进入奔跑状态
                SetGameAct(AvatarUtil.ACT_RUN);
            }
            else
            {
                //点击一次只进入走路状态
                SetGameAct(AvatarUtil.ACT_WALK);
            }

            //记录本地点击鼠标的时间
            time = Time.realtimeSinceStartup;
        }
    }

}
