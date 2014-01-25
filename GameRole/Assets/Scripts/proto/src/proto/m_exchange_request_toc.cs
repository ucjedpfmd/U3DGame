namespace proto {
	public class m_exchange_request_toc : Message
	{
		public int err_code = 0;
		public int exchange_id = 0;
		public int exchange_amount = 0;
		public m_exchange_request_toc() {
		}
		public override string getMethodName() {
			return "exchange_request";
		}
		public override string getClassName() {
			return "m_exchange_request_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"exchange_id", "int", "null"},new string[] {"exchange_amount", "int", "null"}};
		}
	}
}
