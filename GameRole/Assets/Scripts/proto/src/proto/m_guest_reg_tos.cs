namespace proto {
	public class m_guest_reg_tos : Message
	{
		public string account = null;
		public string email = null;
		public string passwd = null;
		public int cid = 3000;
		public m_guest_reg_tos() {
		}
		public override string getMethodName() {
			return "guest_reg";
		}
		public override string getClassName() {
			return "m_guest_reg_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"account", "string", "null"},new string[] {"email", "string", "null"},new string[] {"passwd", "string", "null"},new string[] {"cid", "int", "null"}};
		}
	}
}
