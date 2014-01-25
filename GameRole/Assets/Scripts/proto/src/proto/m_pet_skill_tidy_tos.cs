namespace proto {
	public class m_pet_skill_tidy_tos : Message
	{
		public object[] bag_ids;
		public double pet_id = 0;
		public m_pet_skill_tidy_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_tidy";
		}
		public override string getClassName() {
			return "m_pet_skill_tidy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bag_ids", "array", "int"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
