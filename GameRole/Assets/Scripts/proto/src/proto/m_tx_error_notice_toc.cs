namespace proto {
	public class m_tx_error_notice_toc : Message
	{
		public int error_no = 0;
		public m_tx_error_notice_toc() {
		}
		public override string getMethodName() {
			return "tx_error_notice";
		}
		public override string getClassName() {
			return "m_tx_error_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_no", "int", "null"}};
		}
	}
}
