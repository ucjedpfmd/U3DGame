namespace proto {
	public class m_role_pos_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int op_type = 1;
		public m_role_pos_toc() {
		}
		public override string getMethodName() {
			return "role_pos";
		}
		public override string getClassName() {
			return "m_role_pos_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
