namespace proto {
	public class m_tx_buy_url_toc : Message
	{
		public int error_no = 0;
		public string url = null;
		public bool is_quick = false;
		public m_tx_buy_url_toc() {
		}
		public override string getMethodName() {
			return "tx_buy_url";
		}
		public override string getClassName() {
			return "m_tx_buy_url_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_no", "int", "null"},new string[] {"url", "string", "null"},new string[] {"is_quick", "bool", "null"}};
		}
	}
}
