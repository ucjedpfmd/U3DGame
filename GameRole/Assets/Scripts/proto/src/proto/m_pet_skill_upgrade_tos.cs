namespace proto {
	public class m_pet_skill_upgrade_tos : Message
	{
		public int index = 0;
		public m_pet_skill_upgrade_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_upgrade";
		}
		public override string getClassName() {
			return "m_pet_skill_upgrade_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"index", "int", "null"}};
		}
	}
}
