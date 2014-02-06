using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
	class AvatarUtil
	{
        public const  string ACT_ATTACK = "attack";
		public const  string ACT_ATTACK_ARROW = "attack_arrow";
		public const  string ACT_ATTACK_CASTING = "attack_casting";
		public const  string ACT_DEFAULT = "defult";
		public const  string ACT_DIE = "die";
		public const  string ACT_HURT = "hurt";
		public const  string ACT_SIT = "sit";
		public const  string ACT_STAND = "idle";
		public const  string ACT_WALK = "walk";
		public const  string ACT_RUN = "run";
		public const  string ACT_NO = "no"; //不做任何动作

        ////////////////状态
		public const int NORMAL = 0; //正常
		public const int DEAD = 100; //死亡

        private static Dictionary<int, string> avatarResList;
        public static string getAvatarFBXBySkinID(int skinID)
        {
            init();
            return avatarResList[skinID];
        }

        private static void init()
        {
            if (avatarResList != null)
            {
                return;
            }
            avatarResList = new Dictionary<int, string>();
            avatarResList[1] = "Assets/Standard Assets/Character Controllers/Sources/PrototypeCharacter/Constructor.FBX";
            avatarResList[2] = "Assets/elements/unit/role/100001/role_100001.FBX";
        }
	}
