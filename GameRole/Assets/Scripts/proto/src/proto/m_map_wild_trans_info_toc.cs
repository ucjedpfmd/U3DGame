namespace proto {
	public class m_map_wild_trans_info_toc : Message
	{
		public int err_code = 0;
		public int map_id = 0;
		public object[] trans_info;
		public m_map_wild_trans_info_toc() {
		}
		public override string getMethodName() {
			return "map_wild_trans_info";
		}
		public override string getClassName() {
			return "m_map_wild_trans_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"trans_info", "array", "int"}};
		}
	}
}
