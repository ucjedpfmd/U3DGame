namespace proto {
	public class p_monster_base_info : Message
	{
		public int type_id = 0;
		public string monster_name = null;
		public int level = 0;
		public int attack_type = 0;
		public int max_hp = 0;
		public int max_mp = 0;
		public int attack = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public int hp_recover_speed = 0;
		public int mp_recover_speed = 0;
		public int double_attack = 0;
		public int double_attack_anti = 0;
		public int luck = 0;
		public int move_speed = 0;
		public int attack_speed = 0;
		public int dodge = 0;
		public int no_defence = 0;
		public int phy_hurt_anti = 0;
		public int magic_hurt_anti = 0;
		public int poison_anti = 0;
		public int dizzy_anti = 0;
		public int freeze_anti = 0;
		public int burning_anti = 0;
		public int poison = 0;
		public int dizzy = 0;
		public int freeze = 0;
		public int burning = 0;
		public int hit_rate = 0;
		public int fight_type = 0;
		public int guard_radius = 0;
		public int attention_radius = 0;
		public int activity_radius = 0;
		public p_refresh_info refresh = null;
		public int dead_drop_id = 0;
		public object[] ai_ids;
		public int exp = 0;
		public int skin_id = 0;
		public int is_human = 0;
		public int color = 0;
		public object[] skills;
		public int power = 0;
		public int camp_id = 0;
		public int level_punish = 0;
		public int patrol_rate = 20;
		public p_monster_base_info() {
		}
		public override string getClassName() {
			return "p_monster_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"monster_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"attack_type", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"attack", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"hp_recover_speed", "int", "null"},new string[] {"mp_recover_speed", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"luck", "int", "null"},new string[] {"move_speed", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"no_defence", "int", "null"},new string[] {"phy_hurt_anti", "int", "null"},new string[] {"magic_hurt_anti", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze_anti", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"dizzy", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"fight_type", "int", "null"},new string[] {"guard_radius", "int", "null"},new string[] {"attention_radius", "int", "null"},new string[] {"activity_radius", "int", "null"},new string[] {"refresh", "p_refresh_info", "null"},new string[] {"dead_drop_id", "int", "null"},new string[] {"ai_ids", "array", "int"},new string[] {"exp", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"is_human", "int", "null"},new string[] {"color", "int", "null"},new string[] {"skills", "array", "p_monster_skill"},new string[] {"power", "int", "null"},new string[] {"camp_id", "int", "null"},new string[] {"level_punish", "int", "null"},new string[] {"patrol_rate", "int", "null"}};
		}
	}
}
