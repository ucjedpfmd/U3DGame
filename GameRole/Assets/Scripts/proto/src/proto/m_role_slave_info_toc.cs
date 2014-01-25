namespace proto {
	public class m_role_slave_info_toc : Message
	{
		public int err_code = 0;
		public int role_status = 0;
		public int prestige = 0;
		public int popularity = 0;
		public int catch_times = 0;
		public int all_catch_times = 0;
		public int liberate_times = 0;
		public int all_liberate_times = 0;
		public object[] status_info;
		public object[] recent_info;
		public m_role_slave_info_toc() {
		}
		public override string getMethodName() {
			return "role_slave_info";
		}
		public override string getClassName() {
			return "m_role_slave_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_status", "int", "null"},new string[] {"prestige", "int", "null"},new string[] {"popularity", "int", "null"},new string[] {"catch_times", "int", "null"},new string[] {"all_catch_times", "int", "null"},new string[] {"liberate_times", "int", "null"},new string[] {"all_liberate_times", "int", "null"},new string[] {"status_info", "array", "p_role_slave_status_info"},new string[] {"recent_info", "array", "p_role_slave_recent_info"}};
		}
	}
}
