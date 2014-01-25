namespace proto {
	public class m_market_info_tos : Message
	{
		public double target_role_id = 0;
		public m_market_info_tos() {
		}
		public override string getMethodName() {
			return "market_info";
		}
		public override string getClassName() {
			return "m_market_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_role_id", "double", "null"}};
		}
	}
}
