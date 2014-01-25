namespace proto {
	public class m_evil_mission_accept_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int color_id = 0;
		public m_evil_mission_accept_toc() {
		}
		public override string getMethodName() {
			return "evil_mission_accept";
		}
		public override string getClassName() {
			return "m_evil_mission_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"color_id", "int", "null"}};
		}
	}
}
