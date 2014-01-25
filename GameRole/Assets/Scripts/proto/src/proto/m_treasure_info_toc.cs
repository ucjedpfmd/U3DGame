namespace proto {
	public class m_treasure_info_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public object[] map_id_list;
		public int event_id = 0;
		public int event_map_index = 0;
		public int remain_num = 0;
		public m_treasure_info_toc() {
		}
		public override string getMethodName() {
			return "treasure_info";
		}
		public override string getClassName() {
			return "m_treasure_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"map_id_list", "array", "int"},new string[] {"event_id", "int", "null"},new string[] {"event_map_index", "int", "null"},new string[] {"remain_num", "int", "null"}};
		}
	}
}
