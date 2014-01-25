namespace proto {
	public class m_market_info_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public double target_role_id = 0;
		public object[] market_deals;
		public int income_silver = 0;
		public int income_gold = 0;
		public m_market_info_toc() {
		}
		public override string getMethodName() {
			return "market_info";
		}
		public override string getClassName() {
			return "m_market_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"target_role_id", "double", "null"},new string[] {"market_deals", "array", "p_market_deal"},new string[] {"income_silver", "int", "null"},new string[] {"income_gold", "int", "null"}};
		}
	}
}
