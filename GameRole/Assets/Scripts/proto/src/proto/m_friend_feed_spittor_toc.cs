namespace proto {
	public class m_friend_feed_spittor_toc : Message
	{
		public int err_code = 0;
		public bool return_self = true;
		public double role_id = 0;
		public string rolename = null;
		public int time = 0;
		public int feed_times = 0;
		public int feed_other_times = 0;
		public int tab = 0;
		public m_friend_feed_spittor_toc() {
		}
		public override string getMethodName() {
			return "friend_feed_spittor";
		}
		public override string getClassName() {
			return "m_friend_feed_spittor_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"return_self", "bool", "null"},new string[] {"role_id", "double", "null"},new string[] {"rolename", "string", "null"},new string[] {"time", "int", "null"},new string[] {"feed_times", "int", "null"},new string[] {"feed_other_times", "int", "null"},new string[] {"tab", "int", "null"}};
		}
	}
}
