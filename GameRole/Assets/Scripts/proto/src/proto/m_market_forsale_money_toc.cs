namespace proto {
	public class m_market_forsale_money_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public m_market_forsale_money_toc() {
		}
		public override string getMethodName() {
			return "market_forsale_money";
		}
		public override string getClassName() {
			return "m_market_forsale_money_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
