namespace proto {
	public class m_friend_accept_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public string name = null;
		public object[] friend_info;
		public m_friend_accept_toc() {
		}
		public override string getMethodName() {
			return "friend_accept";
		}
		public override string getClassName() {
			return "m_friend_accept_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"name", "string", "null"},new string[] {"friend_info", "array", "p_friend_info"}};
		}
	}
}
