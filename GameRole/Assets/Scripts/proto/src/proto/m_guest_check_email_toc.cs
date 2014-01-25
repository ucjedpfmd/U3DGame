namespace proto {
	public class m_guest_check_email_toc : Message
	{
		public int result = 0;
		public m_guest_check_email_toc() {
		}
		public override string getMethodName() {
			return "guest_check_email";
		}
		public override string getClassName() {
			return "m_guest_check_email_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"result", "int", "null"}};
		}
	}
}
