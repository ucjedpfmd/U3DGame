namespace proto {
	public class m_tx_vip_tos : Message
	{
		public int op_type = 0;
		public int act_type = 0;
		public int month = 1;
		public m_tx_vip_tos() {
		}
		public override string getMethodName() {
			return "tx_vip";
		}
		public override string getClassName() {
			return "m_tx_vip_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"act_type", "int", "null"},new string[] {"month", "int", "null"}};
		}
	}
}
