namespace proto {
	public class m_mystery_shop_refresh_tos : Message
	{
		public int op_type = 0;
		public bool coupon_first = false;
		public m_mystery_shop_refresh_tos() {
		}
		public override string getMethodName() {
			return "mystery_shop_refresh";
		}
		public override string getClassName() {
			return "m_mystery_shop_refresh_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"coupon_first", "bool", "null"}};
		}
	}
}
