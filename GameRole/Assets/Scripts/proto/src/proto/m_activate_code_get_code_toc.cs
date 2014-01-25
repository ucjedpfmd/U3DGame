namespace proto {
	public class m_activate_code_get_code_toc : Message
	{
		public int err_code = 0;
		public string id = null;
		public string code = null;
		public m_activate_code_get_code_toc() {
		}
		public override string getMethodName() {
			return "activate_code_get_code";
		}
		public override string getClassName() {
			return "m_activate_code_get_code_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"id", "string", "null"},new string[] {"code", "string", "null"}};
		}
	}
}
