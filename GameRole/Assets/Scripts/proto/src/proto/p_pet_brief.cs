namespace proto {
	public class p_pet_brief : Message
	{
		public int index = 0;
		public double pet_id = 0;
		public string name = null;
		public int type_id = 0;
		public int level = 0;
		public int exp = 0;
		public int next_level_exp = 0;
		public int skin_id = 0;
		public int state = 3;
		public p_pet_training training_info = null;
		public p_pet_embattle_info embattle_info = null;
		public int attack_type = 0;
		public p_pet_brief() {
		}
		public override string getClassName() {
			return "p_pet_brief";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"},new string[] {"pet_id", "double", "null"},new string[] {"name", "string", "null"},new string[] {"type_id", "int", "null"},new string[] {"level", "int", "null"},new string[] {"exp", "int", "null"},new string[] {"next_level_exp", "int", "null"},new string[] {"skin_id", "int", "null"},new string[] {"state", "int", "null"},new string[] {"training_info", "p_pet_training", "null"},new string[] {"embattle_info", "p_pet_embattle_info", "null"},new string[] {"attack_type", "int", "null"}};
		}
	}
}
