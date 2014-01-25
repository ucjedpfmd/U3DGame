namespace proto {
	public class m_market_income_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public int income_silver = 0;
		public int income_gold = 0;
		public m_market_income_toc() {
		}
		public override string getMethodName() {
			return "market_income";
		}
		public override string getClassName() {
			return "m_market_income_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"income_silver", "int", "null"},new string[] {"income_gold", "int", "null"}};
		}
	}
}
