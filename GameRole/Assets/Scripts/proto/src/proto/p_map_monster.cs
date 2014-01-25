namespace proto {
	public class p_map_monster : Message
	{
		public int monster_id = 0;
		public int type_id = 0;
		public int state = 0;
		public int map_id = 0;
		public int hp = 0;
		public int mp = 0;
		public int pos = 0;
		public int max_mp = 0;
		public int max_hp = 0;
		public int move_speed = 0;
		public object[] last_walk_path;
		public object[] state_buffs;
		public string monster_name = null;
		public int power = -1;
		public object[] ai_actions;
		public int camp_id = 0;
		public int skin_id = 0;
		public p_map_monster() {
		}
		public override string getClassName() {
			return "p_map_monster";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"state", "int", "null"},new string[] {"map_id", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"mp", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"move_speed", "int", "null"},new string[] {"last_walk_path", "array", "int"},new string[] {"state_buffs", "array", "p_actor_buf"},new string[] {"monster_name", "string", "null"},new string[] {"power", "int", "null"},new string[] {"ai_actions", "array", "p_map_action"},new string[] {"camp_id", "int", "null"},new string[] {"skin_id", "int", "null"}};
		}
	}
}
