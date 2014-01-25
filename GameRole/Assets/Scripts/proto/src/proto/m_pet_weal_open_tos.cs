namespace proto {
	public class m_pet_weal_open_tos : Message
	{
		public double pet_id = 0;
		public int id = 0;
		public m_pet_weal_open_tos() {
		}
		public override string getMethodName() {
			return "pet_weal_open";
		}
		public override string getClassName() {
			return "m_pet_weal_open_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"id", "int", "null"}};
		}
	}
}
