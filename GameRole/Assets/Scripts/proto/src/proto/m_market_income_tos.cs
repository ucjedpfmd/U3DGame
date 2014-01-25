namespace proto {
	public class m_market_income_tos : Message
	{
		public int income_type = 0;
		public m_market_income_tos() {
		}
		public override string getMethodName() {
			return "market_income";
		}
		public override string getClassName() {
			return "m_market_income_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"income_type", "int", "null"}};
		}
	}
}
