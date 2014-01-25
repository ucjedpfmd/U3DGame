namespace proto {
	public class p_other_role_info : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int sex = 0;
		public int faction_id = 0;
		public string family_name = null;
		public string office_name = "";
		public int charm = 0;
		public int category = 0;
		public int level = 0;
		public int level_rank = 0;
		public object[] equips;
		public int vip_level = 0;
		public int pk_point = 0;
		public int moral_value = 0;
		public int hit_rate = 0;
		public int dodge = 0;
		public int attack_speed = 0;
		public int move_speed = 0;
		public int phy_attack = 0;
		public int magic_attack = 0;
		public int double_attack = 0;
		public int double_attack_anti = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public double pet_id = 0;
		public string couple_name = "";
		public int hp = 0;
		public int max_hp = 0;
		public int mp = 0;
		public int max_mp = 0;
		public int power = 0;
		public p_skin skin = null;
		public int family_contribute = 0;
		public object[] role_scores;
		public int devote_num = 0;
		public object[] devotes;
		public int dizzy = 0;
		public int poison = 0;
		public int freeze = 0;
		public int burning = 0;
		public int poison_anti = 0;
		public int dizzy_anti = 0;
		public int freeze_anti = 0;
		public int burning_anti = 0;
		public p_pet pet = null;
		public p_mount mount_info = null;
		public int anima_level = 0;
		public int title_type_id = 0;
		public int contempt = 0;
		public int admire = 0;
		public int pfvip_level = 0;
		public object[] power_infos;
		public object[] use_names;
		public int achieve_rank = 0;
		public object[] achieve_info;
		public int kill_value = 0;
		public p_other_role_info() {
		}
		public override string getClassName() {
			return "p_other_role_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"faction_id", "int", "null"},new string[] {"family_name", "string", "null"},new string[] {"office_name", "string", "null"},new string[] {"charm", "int", "null"},new string[] {"category", "int", "null"},new string[] {"level", "int", "null"},new string[] {"level_rank", "int", "null"},new string[] {"equips", "array", "p_goods"},new string[] {"vip_level", "int", "null"},new string[] {"pk_point", "int", "null"},new string[] {"moral_value", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"attack_speed", "int", "null"},new string[] {"move_speed", "int", "null"},new string[] {"phy_attack", "int", "null"},new string[] {"magic_attack", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"couple_name", "string", "null"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"mp", "int", "null"},new string[] {"max_mp", "int", "null"},new string[] {"power", "int", "null"},new string[] {"skin", "p_skin", "null"},new string[] {"family_contribute", "int", "null"},new string[] {"role_scores", "array", "p_role_score"},new string[] {"devote_num", "int", "null"},new string[] {"devotes", "array", "p_add_prop"},new string[] {"dizzy", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze_anti", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"pet", "p_pet", "null"},new string[] {"mount_info", "p_mount", "null"},new string[] {"anima_level", "int", "null"},new string[] {"title_type_id", "int", "null"},new string[] {"contempt", "int", "null"},new string[] {"admire", "int", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"power_infos", "array", "p_power_info"},new string[] {"use_names", "array", "string"},new string[] {"achieve_rank", "int", "null"},new string[] {"achieve_info", "array", "p_achieve_info"},new string[] {"kill_value", "int", "null"}};
		}
	}
}
