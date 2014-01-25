namespace proto {
	public class m_mission_list_toc : Message
	{
		public int err_code = 0;
		public object[] code_data;
		public object[] list;
		public m_mission_list_toc() {
		}
		public override string getMethodName() {
			return "mission_list";
		}
		public override string getClassName() {
			return "m_mission_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"code_data", "array", "int"},new string[] {"list", "array", "p_mission_info"}};
		}
	}
}
