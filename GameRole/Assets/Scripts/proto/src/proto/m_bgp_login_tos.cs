namespace proto {
	public class m_bgp_login_tos : Message
	{
		public int id = 0;
		public string host = null;
		public int port = 0;
		public m_bgp_login_tos() {
		}
		public override string getMethodName() {
			return "bgp_login";
		}
		public override string getClassName() {
			return "m_bgp_login_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"host", "string", "null"},new string[] {"port", "int", "null"}};
		}
	}
}
