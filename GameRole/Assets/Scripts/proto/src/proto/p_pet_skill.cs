namespace proto {
	public class p_pet_skill : Message
	{
		public int index = 0;
		public int id = 0;
		public int type_id = 0;
		public int skill_level = 1;
		public int skill_exp = 0;
		public int skill_state = 0;
		public int end_time = 0;
		public int suspend = 0;
		public p_pet_skill() {
		}
		public override string getClassName() {
			return "p_pet_skill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"},new string[] {"id", "int", "null"},new string[] {"type_id", "int", "null"},new string[] {"skill_level", "int", "null"},new string[] {"skill_exp", "int", "null"},new string[] {"skill_state", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"suspend", "int", "null"}};
		}
	}
}
