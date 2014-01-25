namespace proto {
	public class m_role_use_bighmp_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int type = 0;
		public int big_hmp = 0;
		public int use_num = 0;
		public m_role_use_bighmp_toc() {
		}
		public override string getMethodName() {
			return "role_use_bighmp";
		}
		public override string getClassName() {
			return "m_role_use_bighmp_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"type", "int", "null"},new string[] {"big_hmp", "int", "null"},new string[] {"use_num", "int", "null"}};
		}
	}
}
