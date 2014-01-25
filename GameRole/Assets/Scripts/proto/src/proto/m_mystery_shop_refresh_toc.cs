namespace proto {
	public class m_mystery_shop_refresh_toc : Message
	{
		public int err_code = 0;
		public object[] goods_list;
		public int luck = 0;
		public int gold = 0;
		public int coupon = 0;
		public int leftfree = 0;
		public m_mystery_shop_refresh_toc() {
		}
		public override string getMethodName() {
			return "mystery_shop_refresh";
		}
		public override string getClassName() {
			return "m_mystery_shop_refresh_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"goods_list", "array", "p_mystery_goods"},new string[] {"luck", "int", "null"},new string[] {"gold", "int", "null"},new string[] {"coupon", "int", "null"},new string[] {"leftfree", "int", "null"}};
		}
	}
}
