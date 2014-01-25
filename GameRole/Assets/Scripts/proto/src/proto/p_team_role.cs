namespace proto {
	public class p_team_role : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int curr_server_id = 0;
		public int map_id = 0;
		public int pos = 0;
		public int hp = 0;
		public int mp = 0;
		public int max_hp = 0;
		public int max_mp = 0;
		public int level = 0;
		public bool is_leader = false;
		public bool is_follow = false;
		public bool is_offline = false;
		public int offline_time = 0;
		public int category = 0;
		public int faction_id = 0;
		public p_skin skin = null;
		public int power = 0;
		public bool show_equip_ring = true;
		public int vip_level = 0;
		public double couple_id = 0;
		public string couple_name = null;
		public p_team_role() {
		}
		public override string getClassName() {
			return "p_team_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"curr_server_id", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"mp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"level", "int", "null"},new string[] {"is_leader", "bool", "null"},new string[] {"is_follow", "bool", "null"},new string[] {"is_offline", "bool", "null"},new string[] {"offline_time", "int", "null"},new string[] {"category", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"skin", "p_skin", "null"},new string[] {"power", "int", "null"},new string[] {"show_equip_ring", "bool", "null"},new string[] {"vip_level", "int", "null"},new string[] {"couple_id", "double", "null"},new string[] {"couple_name", "string", "null"}};
		}
	}
}
