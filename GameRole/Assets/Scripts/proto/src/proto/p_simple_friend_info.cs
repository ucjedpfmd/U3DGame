namespace proto {
	public class p_simple_friend_info : Message
	{
		public string rolename = null;
		public int faction_id = 0;
		public bool is_online = true;
		public int head = 0;
		public int level = 0;
		public p_simple_friend_info() {
		}
		public override string getClassName() {
			return "p_simple_friend_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rolename", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"is_online", "bool", "null"},new string[] {"head", "int", "null"},new string[] {"level", "int", "null"}};
		}
	}
}
