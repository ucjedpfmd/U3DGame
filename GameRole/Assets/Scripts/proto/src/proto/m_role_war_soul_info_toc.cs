namespace proto {
	public class m_role_war_soul_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public p_war_soul_info war_soul_info = null;
		public object[] bag_souls;
		public object[] add_props;
		public m_role_war_soul_info_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_info";
		}
		public override string getClassName() {
			return "m_role_war_soul_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"war_soul_info", "p_war_soul_info", "null"},new string[] {"bag_souls", "array", "p_kv"},new string[] {"add_props", "array", "p_add_prop"}};
		}
	}
}
