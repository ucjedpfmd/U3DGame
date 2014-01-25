namespace proto {
	public class m_guest_check_account_tos : Message
	{
		public string account = null;
		public m_guest_check_account_tos() {
		}
		public override string getMethodName() {
			return "guest_check_account";
		}
		public override string getClassName() {
			return "m_guest_check_account_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"account", "string", "null"}};
		}
	}
}
