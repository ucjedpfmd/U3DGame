namespace proto {
	public class m_market_takeback_tos : Message
	{
		public int goods_id = 0;
		public m_market_takeback_tos() {
		}
		public override string getMethodName() {
			return "market_takeback";
		}
		public override string getClassName() {
			return "m_market_takeback_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"}};
		}
	}
}
