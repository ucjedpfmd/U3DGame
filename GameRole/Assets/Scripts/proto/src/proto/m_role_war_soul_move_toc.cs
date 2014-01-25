namespace proto {
	public class m_role_war_soul_move_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] update_souls;
		public object[] delete_souls;
		public m_role_war_soul_move_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_move";
		}
		public override string getClassName() {
			return "m_role_war_soul_move_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"update_souls", "array", "p_war_soul"},new string[] {"delete_souls", "array", "p_war_soul"}};
		}
	}
}
