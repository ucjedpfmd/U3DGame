namespace module.scene.sceneUnit{
    using UnityEngine;
    using System.Collections;
    using AssemblyCSharp;
    using module.scene.sceneUnit.avatar;
    using com.globals;

    public class MyRole : SceneUnit
    {

        // Use this for initialization
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
            resetSkin(0, 0);
        }

        override public void resetSkin(int skinID, int sex)
        {
			avatar.resetSkin(skinID,sex);
			if(isInit == false){
				initScript();
			}
            
        }

		private void initScript(){
			avatar.body.AddComponent("Controller");
			avatar.body.AddComponent<CharacterController>();
			SmoothFollow sf = GlobalData.camera.GetComponent("SmoothFollow") as SmoothFollow;
			sf.distance = 6;
			sf.height = 4;
			sf.target = avatar.body.transform;
			behaviour = avatar.body.AddComponent("Controller") as Controller;
			behaviour.unitID = id;
			collider = avatar.body.AddComponent<MeshCollider>();
			isInit = true;
		}

        override public void play(string act, string dir = null)
        {
            avatar.body.animation.Play(act);
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public Vector3 pos()
        {
			return myObj.transform.position;
        }

        public void runToPoint(Vector3 pointAft)
        {
            (behaviour as Controller).runToPoint(pointAft);
        }
    }

}
