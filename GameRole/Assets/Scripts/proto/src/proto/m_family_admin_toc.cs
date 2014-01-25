namespace proto {
	public class m_family_admin_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 0;
		public double target_role_id = 0;
		public string target_role_name = null;
		public m_family_admin_toc() {
		}
		public override string getMethodName() {
			return "family_admin";
		}
		public override string getClassName() {
			return "m_family_admin_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"},new string[] {"target_role_id", "double", "null"},new string[] {"target_role_name", "string", "null"}};
		}
	}
}
