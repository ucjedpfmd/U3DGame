namespace proto {
	public class m_vip_stop_notify_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int notify_type = 0;
		public m_vip_stop_notify_toc() {
		}
		public override string getMethodName() {
			return "vip_stop_notify";
		}
		public override string getClassName() {
			return "m_vip_stop_notify_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"notify_type", "int", "null"}};
		}
	}
}
