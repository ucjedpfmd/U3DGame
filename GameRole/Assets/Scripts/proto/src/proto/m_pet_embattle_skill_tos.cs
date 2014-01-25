namespace proto {
	public class m_pet_embattle_skill_tos : Message
	{
		public double pet_id = 0;
		public int new_skill = 0;
		public m_pet_embattle_skill_tos() {
		}
		public override string getMethodName() {
			return "pet_embattle_skill";
		}
		public override string getClassName() {
			return "m_pet_embattle_skill_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"new_skill", "int", "null"}};
		}
	}
}
