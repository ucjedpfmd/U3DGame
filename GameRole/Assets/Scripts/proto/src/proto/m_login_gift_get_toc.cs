namespace proto {
	public class m_login_gift_get_toc : Message
	{
		public int err_code = 0;
		public int gift_type = 0;
		public m_login_gift_get_toc() {
		}
		public override string getMethodName() {
			return "login_gift_get";
		}
		public override string getClassName() {
			return "m_login_gift_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"gift_type", "int", "null"}};
		}
	}
}
