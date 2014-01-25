namespace proto {
	public class m_login_gift_get_tos : Message
	{
		public int gift_type = 0;
		public m_login_gift_get_tos() {
		}
		public override string getMethodName() {
			return "login_gift_get";
		}
		public override string getClassName() {
			return "m_login_gift_get_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"gift_type", "int", "null"}};
		}
	}
}
