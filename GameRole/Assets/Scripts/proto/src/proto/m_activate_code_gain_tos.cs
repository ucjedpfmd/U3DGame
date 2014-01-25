namespace proto {
	public class m_activate_code_gain_tos : Message
	{
		public string code = null;
		public m_activate_code_gain_tos() {
		}
		public override string getMethodName() {
			return "activate_code_gain";
		}
		public override string getClassName() {
			return "m_activate_code_gain_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"code", "string", "null"}};
		}
	}
}
