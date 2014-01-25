namespace proto {
	public class m_vip_get_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int type = 0;
		public int value = 0;
		public m_vip_get_toc() {
		}
		public override string getMethodName() {
			return "vip_get";
		}
		public override string getClassName() {
			return "m_vip_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"type", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
