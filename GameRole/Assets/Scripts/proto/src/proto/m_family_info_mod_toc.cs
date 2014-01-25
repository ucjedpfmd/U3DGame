namespace proto {
	public class m_family_info_mod_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public m_family_info_mod_toc() {
		}
		public override string getMethodName() {
			return "family_info_mod";
		}
		public override string getClassName() {
			return "m_family_info_mod_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
