namespace proto {
	public class m_role_slave_history_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] history_info;
		public m_role_slave_history_toc() {
		}
		public override string getMethodName() {
			return "role_slave_history";
		}
		public override string getClassName() {
			return "m_role_slave_history_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"history_info", "array", "p_role_slave_history_info"}};
		}
	}
}
