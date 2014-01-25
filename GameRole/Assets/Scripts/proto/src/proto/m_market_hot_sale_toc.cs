namespace proto {
	public class m_market_hot_sale_toc : Message
	{
		public object[] hot_sale;
		public m_market_hot_sale_toc() {
		}
		public override string getMethodName() {
			return "market_hot_sale";
		}
		public override string getClassName() {
			return "m_market_hot_sale_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"hot_sale", "array", "string"}};
		}
	}
}
