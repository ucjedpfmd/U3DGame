namespace proto {
	public class m_tx_vip_toc : Message
	{
		public int error_no = 0;
		public int op_type = 0;
		public string token = null;
		public string actid = null;
		public int month = 0;
		public m_tx_vip_toc() {
		}
		public override string getMethodName() {
			return "tx_vip";
		}
		public override string getClassName() {
			return "m_tx_vip_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"error_no", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"token", "string", "null"},new string[] {"actid", "string", "null"},new string[] {"month", "int", "null"}};
		}
	}
}
