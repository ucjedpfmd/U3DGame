namespace proto {
	public class m_market_log_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public double target_id = 0;
		public object[] market_log;
		public m_market_log_toc() {
		}
		public override string getMethodName() {
			return "market_log";
		}
		public override string getClassName() {
			return "m_market_log_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"target_id", "double", "null"},new string[] {"market_log", "array", "p_market_log"}};
		}
	}
}
