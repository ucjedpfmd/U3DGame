namespace proto {
	public class m_login_gift_info_toc : Message
	{
		public int err_code = 0;
		public object[] gift_list;
		public int login_days = 0;
		public m_login_gift_info_toc() {
		}
		public override string getMethodName() {
			return "login_gift_info";
		}
		public override string getClassName() {
			return "m_login_gift_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"gift_list", "array", "p_kv"},new string[] {"login_days", "int", "null"}};
		}
	}
}
