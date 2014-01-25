namespace proto {
	public class m_bgp_login_toc : Message
	{
		public int id = 0;
		public int err_code = 0;
		public string reason = null;
		public m_bgp_login_toc() {
		}
		public override string getMethodName() {
			return "bgp_login";
		}
		public override string getClassName() {
			return "m_bgp_login_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
