namespace proto {
	public class m_market_buy_tos : Message
	{
		public double target_role_id = 0;
		public int goods_id = 0;
		public int num = 0;
		public int goods_price = 0;
		public int goods_price_type = 0;
		public m_market_buy_tos() {
		}
		public override string getMethodName() {
			return "market_buy";
		}
		public override string getClassName() {
			return "m_market_buy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_role_id", "double", "null"},new string[] {"goods_id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"goods_price", "int", "null"},new string[] {"goods_price_type", "int", "null"}};
		}
	}
}
