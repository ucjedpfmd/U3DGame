namespace proto {
	public class m_friend_request_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public object[] request_data;
		public m_friend_request_toc() {
		}
		public override string getMethodName() {
			return "friend_request";
		}
		public override string getClassName() {
			return "m_friend_request_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"request_data", "array", "p_request"}};
		}
	}
}
