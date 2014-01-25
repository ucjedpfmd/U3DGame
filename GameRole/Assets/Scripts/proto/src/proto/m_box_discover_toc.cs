namespace proto {
	public class m_box_discover_toc : Message
	{
		public int err_code = 0;
		public p_my_box_log my_logs = null;
		public p_all_box_log all_logs = null;
		public object[] recent_discover_list;
		public m_box_discover_toc() {
		}
		public override string getMethodName() {
			return "box_discover";
		}
		public override string getClassName() {
			return "m_box_discover_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"my_logs", "p_my_box_log", "null"},new string[] {"all_logs", "p_all_box_log", "null"},new string[] {"recent_discover_list", "array", "p_box_goods"}};
		}
	}
}
