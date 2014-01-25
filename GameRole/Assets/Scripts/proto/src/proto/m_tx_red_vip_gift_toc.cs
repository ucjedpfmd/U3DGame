namespace proto {
	public class m_tx_red_vip_gift_toc : Message
	{
		public int op_type = 0;
		public int err_code = 0;
		public bool can_get = true;
		public bool is_get = true;
		public int upload_times = 0;
		public m_tx_red_vip_gift_toc() {
		}
		public override string getMethodName() {
			return "tx_red_vip_gift";
		}
		public override string getClassName() {
			return "m_tx_red_vip_gift_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"err_code", "int", "null"},new string[] {"can_get", "bool", "null"},new string[] {"is_get", "bool", "null"},new string[] {"upload_times", "int", "null"}};
		}
	}
}
