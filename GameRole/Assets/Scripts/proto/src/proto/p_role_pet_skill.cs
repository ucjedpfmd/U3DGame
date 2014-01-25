namespace proto {
	public class p_role_pet_skill : Message
	{
		public int max_num = 0;
		public object[] pet_skills;
		public int last_id = 0;
		public p_role_pet_skill() {
		}
		public override string getClassName() {
			return "p_role_pet_skill";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_skills", "array", "p_pet_skill"},new string[] {"last_id", "int", "null"}};
		}
	}
}
