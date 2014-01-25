namespace proto {
	public class m_vip_change_map_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_vip_change_map_toc() {
		}
		public override string getMethodName() {
			return "vip_change_map";
		}
		public override string getClassName() {
			return "m_vip_change_map_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
