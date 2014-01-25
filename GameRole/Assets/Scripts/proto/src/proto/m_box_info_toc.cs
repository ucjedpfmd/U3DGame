namespace proto {
	public class m_box_info_toc : Message
	{
		public int err_code = 0;
		public object[] pre_goods_list;
		public object[] recent_discover_list;
		public object[] my_logs;
		public object[] all_logs;
		public object[] prices;
		public int num = 0;
		public int end_time = 0;
		public m_box_info_toc() {
		}
		public override string getMethodName() {
			return "box_info";
		}
		public override string getClassName() {
			return "m_box_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pre_goods_list", "array", "p_box_goods"},new string[] {"recent_discover_list", "array", "p_box_goods"},new string[] {"my_logs", "array", "p_my_box_log"},new string[] {"all_logs", "array", "p_all_box_log"},new string[] {"prices", "array", "p_price"},new string[] {"num", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
