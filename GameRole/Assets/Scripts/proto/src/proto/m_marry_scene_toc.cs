namespace proto {
	public class m_marry_scene_toc : Message
	{
		public int is_begin = 0;
		public int do_num = 0;
		public object[] names;
		public bool horse_state = true;
		public bool ice_npc = true;
		public object[] table_times;
		public m_marry_scene_toc() {
		}
		public override string getMethodName() {
			return "marry_scene";
		}
		public override string getClassName() {
			return "m_marry_scene_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"is_begin", "int", "null"},new string[] {"do_num", "int", "null"},new string[] {"names", "array", "string"},new string[] {"horse_state", "bool", "null"},new string[] {"ice_npc", "bool", "null"},new string[] {"table_times", "array", "p_key_value"}};
		}
	}
}
