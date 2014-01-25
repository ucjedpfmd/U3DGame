namespace proto {
	public class m_role_peace_protect_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public bool is_get = true;
		public m_role_peace_protect_toc() {
		}
		public override string getMethodName() {
			return "role_peace_protect";
		}
		public override string getClassName() {
			return "m_role_peace_protect_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"is_get", "bool", "null"}};
		}
	}
}
