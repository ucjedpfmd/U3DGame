namespace proto {
	public class m_role_war_soul_single_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public string role_name = null;
		public p_war_soul soul = null;
		public m_role_war_soul_single_info_toc() {
		}
		public override string getMethodName() {
			return "role_war_soul_single_info";
		}
		public override string getClassName() {
			return "m_role_war_soul_single_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"soul", "p_war_soul", "null"}};
		}
	}
}
