namespace proto {
	public class p_map_role : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int faction_id = 0;
		public int title_type_id = 0;
		public double family_id = 0;
		public string family_name = null;
		public int curr_server_id = 0;
		public int pos = 0;
		public object[] last_walk_path;
		public int hp = 0;
		public int max_hp = 0;
		public int mp = 0;
		public int max_mp = 0;
		public p_skin skin = null;
		public int move_speed = 0;
		public int team_id = 0;
		public int level = 0;
		public int pk_point = 0;
		public int state = 0;
		public bool gray_name = false;
		public object[] state_buffs;
		public bool show_cloth = true;
		public int equip_ring_color = 0;
		public bool show_equip_ring = true;
		public int vip_level = 0;
		public int rage = 0;
		public int camp_id = 1;
		public string other_value = null;
		public int power = 0;
		public int sex = 0;
		public int category = 0;
		public int pfvip_level = 0;
		public p_family_pet_info family_pets = null;
		public string couple_name = null;
		public p_map_role() {
		}
		public override string getClassName() {
			return "p_map_role";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"faction_id", "int", "null"},new string[] {"title_type_id", "int", "null"},new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"curr_server_id", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"last_walk_path", "array", "int"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"mp", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"skin", "p_skin", "null"},new string[] {"move_speed", "int", "null"},new string[] {"team_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"pk_point", "int", "null"},new string[] {"state", "int", "null"},new string[] {"gray_name", "bool", "null"},new string[] {"state_buffs", "array", "p_actor_buf"},new string[] {"show_cloth", "bool", "null"},new string[] {"equip_ring_color", "int", "null"},new string[] {"show_equip_ring", "bool", "null"},new string[] {"vip_level", "int", "null"},new string[] {"rage", "int", "null"},new string[] {"camp_id", "int", "null"},new string[] {"other_value", "string", "null"},new string[] {"power", "int", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"family_pets", "p_family_pet_info", "null"},new string[] {"couple_name", "string", "null"}};
		}
	}
}
