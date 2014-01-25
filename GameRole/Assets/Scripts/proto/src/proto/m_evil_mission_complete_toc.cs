namespace proto {
	public class m_evil_mission_complete_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public m_evil_mission_complete_toc() {
		}
		public override string getMethodName() {
			return "evil_mission_complete";
		}
		public override string getClassName() {
			return "m_evil_mission_complete_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
