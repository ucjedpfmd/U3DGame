namespace proto {
	public class m_tx_red_vip_gift_tos : Message
	{
		public int op_type = 0;
		public string qq_show = null;
		public m_tx_red_vip_gift_tos() {
		}
		public override string getMethodName() {
			return "tx_red_vip_gift";
		}
		public override string getClassName() {
			return "m_tx_red_vip_gift_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"qq_show", "string", "null"}};
		}
	}
}
