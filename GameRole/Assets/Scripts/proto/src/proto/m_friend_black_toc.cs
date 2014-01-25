namespace proto {
	public class m_friend_black_toc : Message
	{
		public int err_code = 0;
		public p_friend_info friend_info = null;
		public m_friend_black_toc() {
		}
		public override string getMethodName() {
			return "friend_black";
		}
		public override string getClassName() {
			return "m_friend_black_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"friend_info", "p_friend_info", "null"}};
		}
	}
}
