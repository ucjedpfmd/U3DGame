namespace proto {
	public class m_pet_fight_tos : Message
	{
		public double pet_id = 0;
		public m_pet_fight_tos() {
		}
		public override string getMethodName() {
			return "pet_fight";
		}
		public override string getClassName() {
			return "m_pet_fight_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"}};
		}
	}
}
