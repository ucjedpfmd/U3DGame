namespace proto {
	public class m_market_forsale_tos : Message
	{
		public int goods_id = 0;
		public int price = 0;
		public int price_type = 0;
		public int last_hours = 0;
		public m_market_forsale_tos() {
		}
		public override string getMethodName() {
			return "market_forsale";
		}
		public override string getClassName() {
			return "m_market_forsale_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"price", "int", "null"},new string[] {"price_type", "int", "null"},new string[] {"last_hours", "int", "null"}};
		}
	}
}
