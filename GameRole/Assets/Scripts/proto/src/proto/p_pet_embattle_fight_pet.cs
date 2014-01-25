namespace proto {
	public class p_pet_embattle_fight_pet : Message
	{
		public int pos = 0;
		public double pet_id = 0;
		public int pet_type = 0;
		public string pet_name = null;
		public int pet_level = 0;
		public int skin_id = 0;
		public int hp = 0;
		public int max_hp = 0;
		public int skill = 0;
		public p_pet_embattle_fight_pet() {
		}
		public override string getClassName() {
			return "p_pet_embattle_fight_pet";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pos", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"pet_type", "int", "null"},new string[] {"pet_name", "string", "null"},new string[] {"pet_level", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"hp", "int", "null"},new string[] {"max_hp", "int", "null"},new string[] {"skill", "int", "null"}};
		}
	}
}
