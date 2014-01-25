namespace proto {
	public class m_activate_code_list_toc : Message
	{
		public int err_code = 0;
		public object[] list;
		public m_activate_code_list_toc() {
		}
		public override string getMethodName() {
			return "activate_code_list";
		}
		public override string getClassName() {
			return "m_activate_code_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"list", "array", "p_activate_gift"}};
		}
	}
}
