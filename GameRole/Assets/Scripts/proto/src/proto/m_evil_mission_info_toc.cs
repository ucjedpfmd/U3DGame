namespace proto {
	public class m_evil_mission_info_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public double role_id = 0;
		public object[] tokens;
		public object[] release_num;
		public int color_id = 0;
		public m_evil_mission_info_toc() {
		}
		public override string getMethodName() {
			return "evil_mission_info";
		}
		public override string getClassName() {
			return "m_evil_mission_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"role_id", "double", "null"},new string[] {"tokens", "array", "p_evil_mission_token"},new string[] {"release_num", "array", "int"},new string[] {"color_id", "int", "null"}};
		}
	}
}
