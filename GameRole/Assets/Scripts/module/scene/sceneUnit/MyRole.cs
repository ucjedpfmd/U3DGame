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
            //Ŀǰ������ֻ�е���
            //��ʵӦ�����ж�һ�µ�ǰ������ײ���Ķ����Ƿ�Ϊ���Ρ�

            //�õ���3D�����е��������
            pointAft.y = 1;
            point = pointAft;

            //���������泯����㣬���ǵ�X �� Z�᲻Ӧ��������ת��
            //ע��1
            myObj.transform.LookAt(new Vector3(point.x, myObj.transform.position.y, point.z));

            //�û��Ƿ����������ť
            if (Time.realtimeSinceStartup - time <= 0.2f)
            {
                //������� ���뱼��״̬
                SetGameAct(AvatarUtil.ACT_RUN);
            }
            else
            {
                //���һ��ֻ������·״̬
                SetGameAct(AvatarUtil.ACT_WALK);
            }

            //��¼���ص������ʱ��
            time = Time.realtimeSinceStartup;
        }
    }

}
