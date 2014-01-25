namespace module.scene.view{
    using UnityEngine;
    using System.Collections;
    using module.scene.tile;
    using module.scene.sceneUnit.avatar;
    using module.scene.sceneUnit;
    using module.scene.manager;
	using module.scene.utils;
    using com.globals;
	using com.utils;

    public class SceneView
    {

        // Use this for initialization
        GameObject train;
        MyRole myRole;
        MainLight mainLight;
        MainTrrain mainTrrain;
		private GameObject myObj;
		public GameObject midLayer;
        public void init()
        {
            initListener();
			initView();
            initTrain();
            //initMyRole();
            initLight();
            //initMonster();
        }

		public void setParent(GameObject parent){
			myObj.transform.parent = parent.transform;
		}

		private void initView(){
			myObj = new GameObject("SceneView");
			midLayer = new GameObject("midLayer");
			midLayer.transform.parent = myObj.transform;
		}

		public void reset() {
			Vector3 v3 = new Vector3(2992,0,-396);
			midLayer.transform.position = v3;
		}

        private void initListener()
        {
            GlobalData.mouseUtil.addEventListener(InputConstant.EVENT_MOUSE_DOWN_LEFT, onStageMouseDown);
        }

        private void onStageMouseDown(params object[] arg)
        {
            RaycastHit hit = getHit();
            if (hit.collider)
            {
                if (hit.collider.gameObject.name == "MainTrrain")
                {
                    onClickMap(hit);
                }
                else
                {
                    IAvatarBehaviour behaviour = hit.collider.gameObject.GetComponent("IAvatarBehaviour") as IAvatarBehaviour;
                    MyRoleControler.getInstance().onClickUnit(SceneUnitMgr.getUnit(behaviour.unitID));
                }
            }
        }

        private void onClickMap(RaycastHit hit)
        {
            myRole.runToPoint(hit.point);
        }

        private RaycastHit getHit()
        {
            //从摄像机的原点向鼠标点击的对象身上设法一条射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //当射线彭转到对象时
            if (Physics.Raycast(ray, out hit))
            {
                return hit;
            }
            return hit;
        }


        void initTrain()
        {
            mainTrrain = new MainTrrain();
            mainTrrain.init();
        }

        void initMyRole()
        {
            myRole = MyRole.getInstance();
            myRole.id = 1001;
            myRole.reset();
            myRole.play(AvatarUtil.ACT_STAND);
            myRole.resetPos(new Vector3(110, 1, 130));
        }

        void initLight()
        {
            mainLight = new MainLight();
            mainLight.init();
        }

        void initMonster()
        {
            Vector3[] arr = new Vector3[4];
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = new Vector3();
                arr[i].y = 1;
                if (i == 0)
                {
                    arr[i].x = 110;
                    arr[i].z = 128;
                }
                else if (i == 1)
                {
                    arr[i].x = 120;
                    arr[i].z = 120;
                }
                else if (i == 2)
                {
                    arr[i].x = 100;
                    arr[i].z = 140;
                }
                else if (i == 3)
                {
                    arr[i].x = 120;
                    arr[i].z = 140;
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                Monster monster = new Monster();
                monster.id = i;
                monster.reset();
                monster.play(AvatarUtil.ACT_STAND);
                monster.resetPos(arr[i]);
                SceneUnitMgr.addUnit(monster);
            }
        }

        private Vector3 enterPoint = new Vector3();
        public void addUnit(SceneUnit unit, double id, int pos, object vo, int dir = 4) {
			unit.id = id;
			enterPoint = TileUitls.getFlatCenterByPosWithVertor3(pos, enterPoint);       
			if (unit is MyRole) {
                unit.reset();
				//(unit).reset(vo);
				if (unit is MyRole) {
					myRole = unit as MyRole;
					//centerCamera(hero.x, hero.y);
				}
			} else {
                unit.reset();
				unit.play(AvatarUtil.ACT_STAND);
				//unitCache.push([unit, vo, id, 1]);
			}
			unit.setParent(midLayer);
			unit.resetPos(enterPoint);
			SceneUnitMgr.addUnit(unit);
		}

        public void resetMyRolePos(Vector3 pos)
        {
            myRole.resetPos(pos);
        }

        public void clear()
        {

        }
    }
}
