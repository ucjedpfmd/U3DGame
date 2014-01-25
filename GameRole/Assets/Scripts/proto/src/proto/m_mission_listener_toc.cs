namespace proto {
	public class m_mission_listener_toc : Message
	{
		public int err_code = 0;
		public object[] code_data;
		public int mission_id = 0;
		public p_mission_listener listener = null;
		public m_mission_listener_toc() {
		}
		public override string getMethodName() {
			return "mission_listener";
		}
		public override string getClassName() {
			return "m_mission_listener_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"code_data", "array", "int"},new string[] {"mission_id", "int", "null"},new string[] {"listener", "p_mission_listener", "null"}};
		}
	}
}
