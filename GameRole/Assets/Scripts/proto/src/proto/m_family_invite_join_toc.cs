namespace proto {
	public class m_family_invite_join_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public double role_id = 0;
		public string role_name = null;
		public double family_id = 0;
		public string family_name = null;
		public m_family_invite_join_toc() {
		}
		public override string getMethodName() {
			return "family_invite_join";
		}
		public override string getClassName() {
			return "m_family_invite_join_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"}};
		}
	}
}
