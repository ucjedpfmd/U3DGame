namespace proto {
	public class m_friend_modify_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public p_role_ext info = null;
		public m_friend_modify_toc() {
		}
		public override string getMethodName() {
			return "friend_modify";
		}
		public override string getClassName() {
			return "m_friend_modify_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"info", "p_role_ext", "null"}};
		}
	}
}
