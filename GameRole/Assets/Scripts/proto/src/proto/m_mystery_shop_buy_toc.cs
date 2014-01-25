namespace proto {
	public class m_mystery_shop_buy_toc : Message
	{
		public int err_code = 0;
		public int type_id = 0;
		public object[] lucky_records;
		public int coupon = 0;
		public m_mystery_shop_buy_toc() {
		}
		public override string getMethodName() {
			return "mystery_shop_buy";
		}
		public override string getClassName() {
			return "m_mystery_shop_buy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"lucky_records", "array", "string"},new string[] {"coupon", "int", "null"}};
		}
	}
}
