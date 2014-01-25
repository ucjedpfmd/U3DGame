namespace proto {
	public class m_attitude_aim_role_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int times = 0;
		public int optype = 0;
		public int contempt = 0;
		public int admire = 0;
		public m_attitude_aim_role_toc() {
		}
		public override string getMethodName() {
			return "attitude_aim_role";
		}
		public override string getClassName() {
			return "m_attitude_aim_role_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"times", "int", "null"},new string[] {"optype", "int", "null"},new string[] {"contempt", "int", "null"},new string[] {"admire", "int", "null"}};
		}
	}
}
