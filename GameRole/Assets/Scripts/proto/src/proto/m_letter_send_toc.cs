namespace proto {
	public class m_letter_send_toc : Message
	{
		public int err_code = 0;
		public bool send_self = true;
		public p_letter_info letter = null;
		public bool cross = false;
		public m_letter_send_toc() {
		}
		public override string getMethodName() {
			return "letter_send";
		}
		public override string getClassName() {
			return "m_letter_send_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"send_self", "bool", "null"},new string[] {"letter", "p_letter_info", "null"},new string[] {"cross", "bool", "null"}};
		}
	}
}
