namespace proto {
	public class m_system_set_fcm_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public m_system_set_fcm_toc() {
		}
		public override string getMethodName() {
			return "system_set_fcm";
		}
		public override string getClassName() {
			return "m_system_set_fcm_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
