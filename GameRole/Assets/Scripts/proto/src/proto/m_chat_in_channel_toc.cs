namespace proto {
	public class m_chat_in_channel_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int channel = 0;
		public string msg = null;
		public int msg_type = 0;
		public p_chat_role role_info = null;
		public int tstamp = 0;
		public m_chat_in_channel_toc() {
		}
		public override string getMethodName() {
			return "chat_in_channel";
		}
		public override string getClassName() {
			return "m_chat_in_channel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"channel", "int", "null"},new string[] {"msg", "string", "null"},new string[] {"msg_type", "int", "null"},new string[] {"role_info", "p_chat_role", "null"},new string[] {"tstamp", "int", "null"}};
		}
	}
}
