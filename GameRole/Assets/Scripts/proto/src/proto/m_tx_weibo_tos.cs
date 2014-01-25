namespace proto {
	public class m_tx_weibo_tos : Message
	{
		public string content = null;
		public m_tx_weibo_tos() {
		}
		public override string getMethodName() {
			return "tx_weibo";
		}
		public override string getClassName() {
			return "m_tx_weibo_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"content", "string", "null"}};
		}
	}
}
