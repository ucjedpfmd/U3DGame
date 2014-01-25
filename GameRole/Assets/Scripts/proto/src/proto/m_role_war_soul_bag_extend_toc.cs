namespace proto {
	public class m_role_war_soul_bag_extend_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int max_num = 0;
		public m_role_war_soul_bag_extend_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_bag_extend";
		}
		public override string getClassName() {
			return "m_role_war_soul_bag_extend_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"max_num", "int", "null"}};
		}
	}
}
