namespace proto {
	public class m_role_getrolechat_toc : Message
	{
		public bool succ = true;
		public string reason = null;
		public p_other_role_chat_info role_info = null;
		public m_role_getrolechat_toc() {
		}
		public override string getMethodName() {
			return "role_getrolechat";
		}
		public override string getClassName() {
			return "m_role_getrolechat_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"succ", "bool", "null"},new string[] {"reason", "string", "null"},new string[] {"role_info", "p_other_role_chat_info", "null"}};
		}
	}
}
