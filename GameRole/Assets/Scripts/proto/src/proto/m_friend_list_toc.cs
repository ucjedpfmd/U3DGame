namespace proto {
	public class m_friend_list_toc : Message
	{
		public int err_code = 0;
		public int tab = 0;
		public int feed_times = 0;
		public int feed_other_times = 0;
		public bool is_get_reward = true;
		public object[] friend_list;
		public object[] feed_spittor_list;
		public m_friend_list_toc() {
		}
		public override string getMethodName() {
			return "friend_list";
		}
		public override string getClassName() {
			return "m_friend_list_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"tab", "int", "null"},new string[] {"feed_times", "int", "null"},new string[] {"feed_other_times", "int", "null"},new string[] {"is_get_reward", "bool", "null"},new string[] {"friend_list", "array", "p_friend_info"},new string[] {"feed_spittor_list", "array", "p_feed_spittor_info"}};
		}
	}
}
