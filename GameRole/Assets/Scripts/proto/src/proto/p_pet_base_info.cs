namespace proto {
	public class p_pet_base_info : Message
	{
		public int type_id = 0;
		public string pet_name = null;
		public int carry_level = 0;
		public int attack_type = 0;
		public int base_skin_id = 0;
		public object[] base_skills;
		public p_pet_base_info() {
		}
		public override string getClassName() {
			return "p_pet_base_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type_id", "int", "null"},new string[] {"pet_name", "string", "null"},new string[] {"carry_level", "int", "null"},new string[] {"attack_type", "int", "null"},new string[] {"base_skin_id", "int", "null"},new string[] {"base_skills", "array", "p_add_prop"}};
		}
	}
}
