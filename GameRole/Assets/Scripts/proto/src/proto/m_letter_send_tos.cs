namespace proto {
	public class m_letter_send_tos : Message
	{
		public string receiver = null;
		public string title = null;
		public string text = null;
		public m_letter_send_tos() {
		}
		public override string getMethodName() {
			return "letter_send";
		}
		public override string getClassName() {
			return "m_letter_send_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"receiver", "string", "null"},new string[] {"title", "string", "null"},new string[] {"text", "string", "null"}};
		}
	}
}
