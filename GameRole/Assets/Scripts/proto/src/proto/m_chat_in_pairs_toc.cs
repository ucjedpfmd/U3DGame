namespace proto {
	public class m_chat_in_pairs_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public string msg = null;
		public p_chat_role other_role_info = null;
		public int tstamp = 0;
		public bool return_self = true;
		public int op_type = 0;
		public m_chat_in_pairs_toc() {
		}
		public override string getMethodName() {
			return "chat_in_pairs";
		}
		public override string getClassName() {
			return "m_chat_in_pairs_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"msg", "string", "null"},new string[] {"other_role_info", "p_chat_role", "null"},new string[] {"tstamp", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
