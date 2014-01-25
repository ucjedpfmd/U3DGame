namespace proto {
	public class p_monster : Message
	{
		public int monster_id = 0;
		public int type_id = 0;
		public string monster_name = null;
		public int level = 0;
		public int skin_id = 0;
		public int reborn_pos = 0;
		public object[] reborn_pos_overlap;
		public object[] first_enemies;
		public object[] second_enemies;
		public object[] third_enemies;
		public object[] buffs;
		public int power = 0;
		public int attack_type = 0;
		public int max_mp = 0;
		public int max_hp = 0;
		public int hp_recover_speed = 0;
		public int mp_recover_speed = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public int attack = 0;
		public int move_speed = 0;
		public int attack_speed = 0;
		public int hit_rate = 0;
		public int dodge = 0;
		public int luck = 0;
		public int no_defence = 0;
		public int double_attack = 0;
		public int double_attack_anti = 0;
		public int phy_hurt_rate = 0;
		public int phy_hurt_anti = 0;
		public int magic_hurt_rate = 0;
		public int magic_hurt_anti = 0;
		public int hurt_rebound = 0;
		public int poison = 0;
		public int poison_anti = 0;
		public int burning = 0;
		public int burning_anti = 0;
		public int dizzy = 0;
		public int dizzy_anti = 0;
		public int freeze = 0;
		public int freeze_anti = 0;
		public p_monster() {
		}
		public override string getClassName() {
			return "p_monster";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"monster_id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"monster_name", "string", "null"},new string[] {"level", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"reborn_pos", "int", "null"},new string[] {"reborn_pos_overlap", "array", "bool"},new string[] {"first_enemies", "array", "p_enemy"},new string[] {"second_enemies", "array", "p_enemy"},new string[] {"third_enemies", "array", "p_enemy"},new string[] {"buffs", "array", "p_actor_buf"},new string[] {"power", "int", "null"},new string[] {"attack_type", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"hp_recover_speed", "int", "null"},new string[] {"mp_recover_speed", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"attack", "int", "null"},new string[] {"move_speed", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"luck", "int", "null"},new string[] {"no_defence", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"phy_hurt_rate", "int", "null"},new string[] {"phy_hurt_anti", "int", "null"},new string[] {"magic_hurt_rate", "int", "null"},new string[] {"magic_hurt_anti", "int", "null"},new string[] {"hurt_rebound", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"dizzy", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"freeze_anti", "int", "null"}};
		}
	}
}
