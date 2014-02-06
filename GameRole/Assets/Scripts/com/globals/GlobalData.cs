namespace com.globals{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using UnityEngine;
    using module.scene.tile;
using proto;

    class GlobalData
    {
        public static GameObject camera;
        public static MouseUtil mouseUtil;

        public static void initCamera(GameObject tarCamera)
        {
            camera = tarCamera;
            camera.AddComponent("SmoothFollow");
		    initMouse();
        }

        private static void initMouse()
        {
            mouseUtil = camera.AddComponent("MouseUtil") as MouseUtil;
        }

        private static GlobalData _instance;
        public static GlobalData getInstance()
        {
            if (_instance == null)
            {
                _instance = new GlobalData();
            }
            return _instance;
        }

        public Pt bornPoint; //跳转地图时，先记录下下个地图的出生点
        public int campId;
        private p_role_data _user;

		public p_role_data user {
            get{return _user;}
            set{_user = value;}
		}

        public double getRoleID() {
			return user.attr.role_id;
		}
    }

}
