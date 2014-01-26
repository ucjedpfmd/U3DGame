namespace module.scene.manager
{
    using proto;
	class SceneDataManager
	{
        public static bool isGaming; //场景是否准备好，没准备好不允许东西进入，忽略进入的消息
        //public static mapData;
        private static m_map_change_map_toc _changeVo;
        public static int lineID;

        public static float mapOffsetX;
        public static float mapOffsetZ;

		public static m_map_change_map_toc changeVo {
            get { return _changeVo; }
            set { _changeVo = value; }
		}

        public static int mapID {
            get { return 10000; }
		}
	}
}
