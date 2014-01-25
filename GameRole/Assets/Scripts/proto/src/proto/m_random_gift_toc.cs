namespace proto {
	public class m_random_gift_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public int goods_id = 0;
		public object[] show_list;
		public int wish_value = 0;
		public int open_number = 0;
		public int next_open_price = 0;
		public int max_number = 0;
		public int max_wish_value = 0;
		public int cur_random_goods = 0;
		public int next_add_wish = 0;
		public int type_id = 0;
		public m_random_gift_toc() {
		}
		public override string getMethodName() {
			return "random_gift";
		}
		public override string getClassName() {
			return "m_random_gift_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"goods_id", "int", "null"},new string[] {"show_list", "array", "p_random_gift_show"},new string[] {"wish_value", "int", "null"},new string[] {"open_number", "int", "null"},new string[] {"next_open_price", "int", "null"},new string[] {"max_number", "int", "null"},new string[] {"max_wish_value", "int", "null"},new string[] {"cur_random_goods", "int", "null"},new string[] {"next_add_wish", "int", "null"},new string[] {"type_id", "int", "null"}};
		}
	}
}
