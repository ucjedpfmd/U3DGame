namespace proto {
	public class m_pet_skill_forget_tos : Message
	{
		public object[] indexs;
		public double pet_id = 0;
		public m_pet_skill_forget_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_forget";
		}
		public override string getClassName() {
			return "m_pet_skill_forget_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"indexs", "array", "int"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
