namespace proto {
	public class p_friend_info : Message
	{
		public double role_id = 0;
		public string rolename = null;
		public int type = 0;
		public int sex = 0;
		public int faction_id = 0;
		public int level = 0;
		public int friendly = 0;
		public bool is_online = true;
		public string family_name = null;
		public object[] relative;
		public int category = 0;
		public int vip_level = 0;
		public string faction_office_name = null;
		public int family_title_id = 0;
		public object[] role_news;
		public double last_offline_time = 0;
		public int kill_times = 0;
		public int killed_times = 0;
		public bool can_feed = true;
		public int pfvip_level = 0;
		public int server_id = 0;
		public p_friend_info() {
		}
		public override string getClassName() {
			return "p_friend_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"rolename", "string", "null"},new string[] {"type", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"friendly", "int", "null"},new string[] {"is_online", "bool", "null"},new string[] {"family_name", "string", "null"},new string[] {"relative", "array", "int"},new string[] {"category", "int", "null"},new string[] {"vip_level", "int", "null"},new string[] {"faction_office_name", "string", "null"},new string[] {"family_title_id", "int", "null"},new string[] {"role_news", "array", "p_role_news"},new string[] {"last_offline_time", "double", "null"},new string[] {"kill_times", "int", "null"},new string[] {"killed_times", "int", "null"},new string[] {"can_feed", "bool", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"server_id", "int", "null"}};
		}
	}
}
