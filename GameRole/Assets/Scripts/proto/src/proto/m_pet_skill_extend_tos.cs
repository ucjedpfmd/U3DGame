namespace proto {
	public class m_pet_skill_extend_tos : Message
	{
		public double pet_id = 0;
		public m_pet_skill_extend_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_extend";
		}
		public override string getClassName() {
			return "m_pet_skill_extend_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"}};
		}
	}
}