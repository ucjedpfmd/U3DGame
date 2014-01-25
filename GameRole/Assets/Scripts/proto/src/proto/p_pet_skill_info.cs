namespace proto {
	public class p_pet_skill_info : Message
	{
		public int max_num = 0;
		public object[] pet_skills;
		public p_pet_skill_info() {
		}
		public override string getClassName() {
			return "p_pet_skill_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"max_num", "int", "null"},new string[] {"pet_skills", "array", "p_pet_skill"}};
		}
	}
}
