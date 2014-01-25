namespace proto {
	public class p_pet_embattle_attr : Message
	{
		public double pet_id = 0;
		public string pet_name = null;
		public int pet_type_id = 0;
		public int pet_skin_id = 0;
		public int pet_level = 0;
		public int embattle_pos = 0;
		public int embattle_skill = 0;
		public int embattle_rage = 0;
		public int embattle_seq = 0;
		public int attack_type = 0;
		public int single_skill_lv = 0;
		public int group_skill_lv = 0;
		public int hp = 0;
		public int max_hp = 0;
		public int phy_defence = 0;
		public int magic_defence = 0;
		public int phy_attack = 0;
		public int magic_attack = 0;
		public int double_attack = 0;
		public int double_attack_anti = 0;
		public int hit_rate = 0;
		public int dodge = 0;
		public int poison = 0;
		public int burning = 0;
		public int dizzy = 0;
		public int freeze = 0;
		public int poison_anti = 0;
		public int burning_anti = 0;
		public int dizzy_anti = 0;
		public int freeze_anti = 0;
		public int poison_round = 0;
		public int burning_round = 0;
		public int dizzy_round = 0;
		public int freeze_round = 0;
		public int immune_round = 0;
		public int power = 0;
		public p_pet_embattle_attr() {
		}
		public override string getClassName() {
			return "p_pet_embattle_attr";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"pet_name", "string", "null"},new string[] {"pet_type_id", "int", "null"},new string[] {"pet_skin_id", "int", "null"},new string[] {"pet_level", "int", "null"},new string[] {"embattle_pos", "int", "null"},new string[] {"embattle_skill", "int", "null"},new string[] {"embattle_rage", "int", "null"},new string[] {"embattle_seq", "int", "null"},new string[] {"attack_type", "int", "null"},new string[] {"single_skill_lv", "int", "null"},new string[] {"group_skill_lv", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"phy_defence", "int", "null"},new string[] {"magic_defence", "int", "null"},new string[] {"phy_attack", "int", "null"},new string[] {"magic_attack", "int", "null"},new string[] {"double_attack", "int", "null"},new string[] {"double_attack_anti", "int", "null"},new string[] {"hit_rate", "int", "null"},new string[] {"dodge", "int", "null"},new string[] {"poison", "int", "null"},new string[] {"burning", "int", "null"},new string[] {"dizzy", "int", "null"},new string[] {"freeze", "int", "null"},new string[] {"poison_anti", "int", "null"},new string[] {"burning_anti", "int", "null"},new string[] {"dizzy_anti", "int", "null"},new string[] {"freeze_anti", "int", "null"},new string[] {"poison_round", "int", "null"},new string[] {"burning_round", "int", "null"},new string[] {"dizzy_round", "int", "null"},new string[] {"freeze_round", "int", "null"},new string[] {"immune_round", "int", "null"},new string[] {"power", "int", "null"}};
		}
	}
}
