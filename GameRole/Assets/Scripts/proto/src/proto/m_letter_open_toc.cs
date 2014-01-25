namespace proto {
	public class m_letter_open_toc : Message
	{
		public int err_code = 0;
		public int letter_id = 0;
		public m_letter_open_toc() {
		}
		public override string getMethodName() {
			return "letter_open";
		}
		public override string getClassName() {
			return "m_letter_open_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"letter_id", "int", "null"}};
		}
	}
}
