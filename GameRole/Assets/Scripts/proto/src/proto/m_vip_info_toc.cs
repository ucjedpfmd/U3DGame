namespace proto {
	public class m_vip_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_role_vip vip_info = null;
		public m_vip_info_toc() {
		}
		public override string getMethodName() {
			return "vip_info";
		}
		public override string getClassName() {
			return "m_vip_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"vip_info", "p_role_vip", "null"}};
		}
	}
}
