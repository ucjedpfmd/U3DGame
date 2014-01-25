namespace proto {
	public class m_pet_skill_seal_tos : Message
	{
		public int index = 0;
		public bool auto_buy = true;
		public m_pet_skill_seal_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_seal";
		}
		public override string getClassName() {
			return "m_pet_skill_seal_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"},new string[] {"auto_buy", "bool", "null"}};
		}
	}
}
