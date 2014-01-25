namespace proto {
	public class m_vip_active_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_role_vip vip_info = null;
		public int gold = 0;
		public int item_id = 0;
		public m_vip_active_toc() {
		}
		public override string getMethodName() {
			return "vip_active";
		}
		public override string getClassName() {
			return "m_vip_active_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"vip_info", "p_role_vip", "null"},new string[] {"gold", "int", "null"},new string[] {"item_id", "int", "null"}};
		}
	}
}
