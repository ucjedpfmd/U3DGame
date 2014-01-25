namespace proto {
	public class m_friend_get_info_toc : Message
	{
		public int err_code = 0;
		public p_friend_info roleinfo = null;
		public m_friend_get_info_toc() {
		}
		public override string getMethodName() {
			return "friend_get_info";
		}
		public override string getClassName() {
			return "m_friend_get_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"roleinfo", "p_friend_info", "null"}};
		}
	}
}
