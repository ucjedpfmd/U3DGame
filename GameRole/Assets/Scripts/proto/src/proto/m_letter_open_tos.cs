namespace proto {
	public class m_letter_open_tos : Message
	{
		public int letter_id = 0;
		public bool send_self = false;
		public m_letter_open_tos() {
		}
		public override string getMethodName() {
			return "letter_open";
		}
		public override string getClassName() {
			return "m_letter_open_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"letter_id", "int", "null"},new string[] {"send_self", "bool", "null"}};
		}
	}
}
