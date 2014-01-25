namespace proto {
	public class p_role_base : Message
	{
		public double role_id = 0;
		public int max_hp = 0;
		public int max_mp = 0;
		public int str = 0;
		public int int2 = 0;
		public int con = 0;
		public int dex = 0;
		public int men = 0;
		public int base_str = 0;
		public int base_int = 0;
		public int base_con = 0;
		public int base_dex = 0;
		public int base_men = 0;
		public int phy_attack = 0;
		public int magic_attack = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public int hp_recover_speed = 0;
		public int mp_recover_speed = 0;
		public int base_move_speed = 0;
		public int move_speed = 0;
		public int attack_speed = 0;
		public int luck = 0;
		public int no_defence = 0;
		public int hit_rate = 0;
		public int dodge = 0;
		public int double_attack = 0;
		public int double_attack_anti = 0;
		public int phy_hurt_rate = 0;
		public int magic_hurt_rate = 0;
		public int phy_hurt_anti = 0;
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
		public p_role_base() {
		}
		public override string getClassName() {
			return "p_role_base";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"max_hp", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"str", "int", "null"},new string[] {"int2", "int", "null"},new string[] {"con", "int", "null"},new string[] {"dex", "int", "null"},new string[] {"men", "int", "null"},new string[] {"base_str", "int", "null"},new string[] {"base_int", "int", "null"},new string[] {"base_con", "int", "null"},new string[] {"base_dex", "int", "null"},new string[] {"base_men", "int", "null"},new string[] {"phy_attack", "int", "null"},new string[] {"magic_attack", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"hp_recover_speed", "int", "null"},new string[] {"mp_recover_speed", "int", "null"},new string[] {"base_move_speed", "int", "null"},new string[] {"move_speed", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"luck", "int", "null"},new string[] {"no_defence", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"phy_hurt_rate", "int", "null"},new string[] {"magic_hurt_rate", "int", "null"},new string[] {"phy_hurt_anti", "int", "null"},new string[] {"magic_hurt_anti", "int", "null"},new string[] {"hurt_rebound", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"dizzy", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"freeze_anti", "int", "null"}};
		}
	}
}
