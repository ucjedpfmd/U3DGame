namespace proto {
	public class m_activate_code_get_code_tos : Message
	{
		public string id = null;
		public m_activate_code_get_code_tos() {
		}
		public override string getMethodName() {
			return "activate_code_get_code";
		}
		public override string getClassName() {
			return "m_activate_code_get_code_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "string", "null"}};
		}
	}
}
