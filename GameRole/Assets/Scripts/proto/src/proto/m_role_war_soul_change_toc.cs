namespace proto {
	public class m_role_war_soul_change_toc : Message
	{
		public int op_type = 0;
		public object[] update_souls;
		public object[] delete_souls;
		public int max_num = 0;
		public m_role_war_soul_change_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_change";
		}
		public override string getClassName() {
			return "m_role_war_soul_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"update_souls", "array", "p_war_soul"},new string[] {"delete_souls", "array", "p_war_soul"},new string[] {"max_num", "int", "null"}};
		}
	}
}
