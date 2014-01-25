namespace proto {
	public class m_pet_change_title_tos : Message
	{
		public double pet_id = 0;
		public int title_id = 0;
		public m_pet_change_title_tos() {
		}
		public override string getMethodName() {
			return "pet_change_title";
		}
		public override string getClassName() {
			return "m_pet_change_title_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"title_id", "int", "null"}};
		}
	}
}
