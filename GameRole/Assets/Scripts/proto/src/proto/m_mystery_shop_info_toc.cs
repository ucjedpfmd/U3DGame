namespace proto {
	public class m_mystery_shop_info_toc : Message
	{
		public int err_code = 0;
		public object[] goods_list;
		public int luck = 0;
		public object[] lucky_records;
		public int leftfree = 0;
		public object[] rare_list;
		public m_mystery_shop_info_toc() {
		}
		public override string getMethodName() {
			return "mystery_shop_info";
		}
		public override string getClassName() {
			return "m_mystery_shop_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"goods_list", "array", "p_mystery_goods"},new string[] {"luck", "int", "null"},new string[] {"lucky_records", "array", "string"},new string[] {"leftfree", "int", "null"},new string[] {"rare_list", "array", "int"}};
		}
	}
}
