namespace proto {
	public class p_pet : Message
	{
		public double pet_id = 0;
		public int type_id = 0;
		public double role_id = 0;
		public string role_name = null;
		public string pet_name = null;
		public int attack_type = 0;
		public int property = 0;
		public int aptitude = 0;
		public bool bind = true;
		public int state = 3;
		public int index = 0;
		public int skin_id = 0;
		public int level = 0;
		public double exp = 0;
		public double next_level_exp = 0;
		public int title_id = 0;
		public int create_time = 0;
		public int pk_mode = 0;
		public int attack_mode = 0;
		public int origin = 0;
		public int power = 0;
		public int hp = 0;
		public int max_hp = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public int phy_attack = 0;
		public int magic_attack = 0;
		public int hit_rate = 0;
		public int dodge = 0;
		public int attack_speed = 0;
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
		public int burning = 0;
		public int dizzy = 0;
		public int freeze = 0;
		public int poison_anti = 0;
		public int burning_anti = 0;
		public int dizzy_anti = 0;
		public int freeze_anti = 0;
		public object[] buffs;
		public p_pet_training training_info = null;
		public p_pet_skill_info skill_info = null;
		public p_pet_title_info title_info = null;
		public p_pet_soul_info soul_info = null;
		public p_pet_embattle_info embattle_info = null;
		public object[] equips;
		public p_pet() {
		}
		public override string getClassName() {
			return "p_pet";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"type_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"pet_name", "string", "null"},new string[] {"attack_type", "int", "null"},new string[] {"property", "int", "null"},new string[] {"aptitude", "int", "null"},new string[] {"bind", "bool", "null"},new string[] {"state", "int", "null"},new string[] {"index", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"exp", "double", "null"},new string[] {"next_level_exp", "double", "null"},new string[] {"title_id", "int", "null"},new string[] {"create_time", "int", "null"},new string[] {"pk_mode", "int", "null"},new string[] {"attack_mode", "int", "null"},new string[] {"origin", "int", "null"},new string[] {"power", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"phy_attack", "int", "null"},new string[] {"magic_attack", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"luck", "int", "null"},new string[] {"no_defence", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"phy_hurt_rate", "int", "null"},new string[] {"phy_hurt_anti", "int", "null"},new string[] {"magic_hurt_rate", "int", "null"},new string[] {"magic_hurt_anti", "int", "null"},new string[] {"hurt_rebound", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"dizzy", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze_anti", "int", "null"},new string[] {"buffs", "array", "p_actor_buf"},new string[] {"training_info", "p_pet_training", "null"},new string[] {"skill_info", "p_pet_skill_info", "null"},new string[] {"title_info", "p_pet_title_info", "null"},new string[] {"soul_info", "p_pet_soul_info", "null"},new string[] {"embattle_info", "p_pet_embattle_info", "null"},new string[] {"equips", "array", "p_goods"}};
		}
	}
}
