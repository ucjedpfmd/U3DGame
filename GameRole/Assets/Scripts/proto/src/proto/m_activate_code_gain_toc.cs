namespace proto {
	public class m_activate_code_gain_toc : Message
	{
		public int error_no = 0;
		public m_activate_code_gain_toc() {
		}
		public override string getMethodName() {
			return "activate_code_gain";
		}
		public override string getClassName() {
			return "m_activate_code_gain_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_no", "int", "null"}};
		}
	}
}
