namespace proto {
	public class m_shop_buy_tos : Message
	{
		public int goods_id = 0;
		public bool bind_first = false;
		public int goods_num = 1;
		public int shop_id = 0;
		public bool auto_use = false;
		public m_shop_buy_tos() {
		}
		public override string getMethodName() {
			return "shop_buy";
		}
		public override string getClassName() {
			return "m_shop_buy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"bind_first", "bool", "null"},new string[] {"goods_num", "int", "null"},new string[] {"shop_id", "int", "null"},new string[] {"auto_use", "bool", "null"}};
		}
	}
}
