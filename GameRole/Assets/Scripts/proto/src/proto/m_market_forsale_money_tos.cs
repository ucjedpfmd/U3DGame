namespace proto {
	public class m_market_forsale_money_tos : Message
	{
		public int money_type = 0;
		public int money_num = 0;
		public int price_value = 0;
		public int last_hours = 0;
		public m_market_forsale_money_tos() {
		}
		public override string getMethodName() {
			return "market_forsale_money";
		}
		public override string getClassName() {
			return "m_market_forsale_money_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"money_type", "int", "null"},new string[] {"money_num", "int", "null"},new string[] {"price_value", "int", "null"},new string[] {"last_hours", "int", "null"}};
		}
	}
}
