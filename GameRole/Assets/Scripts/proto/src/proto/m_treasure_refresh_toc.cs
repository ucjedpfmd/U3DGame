namespace proto {
	public class m_treasure_refresh_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public object[] map_id_list;
		public m_treasure_refresh_toc() {
		}
		public override string getMethodName() {
			return "treasure_refresh";
		}
		public override string getClassName() {
			return "m_treasure_refresh_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"map_id_list", "array", "int"}};
		}
	}
}
