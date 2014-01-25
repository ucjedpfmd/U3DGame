namespace proto {
	public class m_role_rename_toc : Message
	{
		public int op_type = 0;
		public int err_code = 0;
		public int need_gold = 0;
		public string new_name = null;
		public m_role_rename_toc() {
		}
		public override string getMethodName() {
			return "role_rename";
		}
		public override string getClassName() {
			return "m_role_rename_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"need_gold", "int", "null"},new string[] {"new_name", "string", "null"}};
		}
	}
}
