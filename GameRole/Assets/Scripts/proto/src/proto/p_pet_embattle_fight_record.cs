namespace proto {
	public class p_pet_embattle_fight_record : Message
	{
		public int active_pos = 0;
		public int active_remain_rage = 0;
		public int passive_pos = 0;
		public bool is_miss = false;
		public bool is_rage = false;
		public int skill_id = 0;
		public object[] attack_effects;
		public object[] status_effects;
		public object[] new_pets;
		public p_pet_embattle_fight_record() {
		}
		public override string getClassName() {
			return "p_pet_embattle_fight_record";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"active_pos", "int", "null"},new string[] {"active_remain_rage", "int", "null"},new string[] {"passive_pos", "int", "null"},new string[] {"is_miss", "bool", "null"},new string[] {"is_rage", "bool", "null"},new string[] {"skill_id", "int", "null"},new string[] {"attack_effects", "array", "p_pet_embattle_attack_effect"},new string[] {"status_effects", "array", "p_pet_embattle_status_effect"},new string[] {"new_pets", "array", "p_pet_embattle_fight_pet"}};
		}
	}
}
