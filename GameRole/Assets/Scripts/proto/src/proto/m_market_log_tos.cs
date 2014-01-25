namespace proto {
	public class m_market_log_tos : Message
	{
		public double target_id = 0;
		public m_market_log_tos() {
		}
		public override string getMethodName() {
			return "market_log";
		}
		public override string getClassName() {
			return "m_market_log_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_id", "double", "null"}};
		}
	}
}
