namespace proto {
	public class m_friend_offline_request_toc : Message
	{
		public object[] request_list;
		public m_friend_offline_request_toc() {
		}
		public override string getMethodName() {
			return "friend_offline_request";
		}
		public override string getClassName() {
			return "m_friend_offline_request_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"request_list", "array", "p_simple_friend_info"}};
		}
	}
}
