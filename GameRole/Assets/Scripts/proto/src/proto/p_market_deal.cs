namespace proto {
	public class p_market_deal : Message
	{
		public int goods_id = 0;
		public p_goods goods = null;
		public int price = 0;
		public int price_type = 0;
		public int end_time = 0;
		public p_market_deal() {
		}
		public override string getClassName() {
			return "p_market_deal";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"goods", "p_goods", "null"},new string[] {"price", "int", "null"},new string[] {"price_type", "int", "null"},new string[] {"end_time", "int", "null"}};
		}
	}
}
