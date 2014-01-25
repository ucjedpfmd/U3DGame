namespace proto {
	public class m_role_come_back_info_toc : Message
	{
		public int err_code = 0;
		public int back_days = 0;
		public int login_days = 0;
		public int award_exp = 0;
		public object[] fetch_flag;
		public m_role_come_back_info_toc() {
		}
		public override string getMethodName() {
			return "role_come_back_info";
		}
		public override string getClassName() {
			return "m_role_come_back_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"back_days", "int", "null"},new string[] {"login_days", "int", "null"},new string[] {"award_exp", "int", "null"},new string[] {"fetch_flag", "array", "p_kv"}};
		}
	}
}
