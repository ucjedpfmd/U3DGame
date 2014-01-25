namespace proto {
	public class m_role_compare_power_toc : Message
	{
		public int err_code = 0;
		public double other_role_id = 0;
		public object[] other_power_infos;
		public int other_platform_level = 0;
		public int other_vip_level = 0;
		public string other_role_name = null;
		public int other_sex = 0;
		public int other_category = 0;
		public int other_power_rank = 0;
		public int other_power = 0;
		public int my_power_rank = 0;
		public m_role_compare_power_toc() {
		}
		public override string getMethodName() {
			return "role_compare_power";
		}
		public override string getClassName() {
			return "m_role_compare_power_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"other_role_id", "double", "null"},new string[] {"other_power_infos", "array", "p_power_info"},new string[] {"other_platform_level", "int", "null"},new string[] {"other_vip_level", "int", "null"},new string[] {"other_role_name", "string", "null"},new string[] {"other_sex", "int", "null"},new string[] {"other_category", "int", "null"},new string[] {"other_power_rank", "int", "null"},new string[] {"other_power", "int", "null"},new string[] {"my_power_rank", "int", "null"}};
		}
	}
}
