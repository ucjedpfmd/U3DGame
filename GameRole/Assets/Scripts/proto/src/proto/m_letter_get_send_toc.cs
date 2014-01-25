namespace proto {
	public class m_letter_get_send_toc : Message
	{
		public object[] letters;
		public m_letter_get_send_toc() {
		}
		public override string getMethodName() {
			return "letter_get_send";
		}
		public override string getClassName() {
			return "m_letter_get_send_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"letters", "array", "p_letter_info"}};
		}
	}
}
