namespace proto {
	public class m_friend_recommend_toc : Message
	{
		public int err_code = 0;
		public object[] friend_info;
		public m_friend_recommend_toc() {
		}
		public override string getMethodName() {
			return "friend_recommend";
		}
		public override string getClassName() {
			return "m_friend_recommend_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"friend_info", "array", "p_recommend_member_info"}};
		}
	}
}
