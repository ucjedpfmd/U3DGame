namespace proto {
	public class m_guest_check_email_tos : Message
	{
		public string email = null;
		public m_guest_check_email_tos() {
		}
		public override string getMethodName() {
			return "guest_check_email";
		}
		public override string getClassName() {
			return "m_guest_check_email_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"email", "string", "null"}};
		}
	}
}
