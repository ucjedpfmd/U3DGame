namespace proto {
	public class m_role_war_soul_bag_toc : Message
	{
		public int op_type = 0;
		public p_war_soul_info war_soul_info = null;
		public m_role_war_soul_bag_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_bag";
		}
		public override string getClassName() {
			return "m_role_war_soul_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"war_soul_info", "p_war_soul_info", "null"}};
		}
	}
}
