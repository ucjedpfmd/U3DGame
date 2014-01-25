namespace proto {
	public class m_broadcast_laba_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public string reason = null;
		public string content = null;
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int laba_id = 0;
		public m_broadcast_laba_toc() {
		}
		public override string getMethodName() {
			return "broadcast_laba";
		}
		public override string getClassName() {
			return "m_broadcast_laba_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"content", "string", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"laba_id", "int", "null"}};
		}
	}
}
