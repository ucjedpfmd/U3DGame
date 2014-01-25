namespace proto {
	public class m_tx_exchange_url_toc : Message
	{
		public int error_no = 0;
		public string url = null;
		public m_tx_exchange_url_toc() {
		}
		public override string getMethodName() {
			return "tx_exchange_url";
		}
		public override string getClassName() {
			return "m_tx_exchange_url_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_no", "int", "null"},new string[] {"url", "string", "null"}};
		}
	}
}
