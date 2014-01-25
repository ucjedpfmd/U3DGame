namespace proto {
	public class m_pet_change_name_tos : Message
	{
		public double pet_id = 0;
		public string pet_name = null;
		public m_pet_change_name_tos() {
		}
		public override string getMethodName() {
			return "pet_change_name";
		}
		public override string getClassName() {
			return "m_pet_change_name_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"pet_name", "string", "null"}};
		}
	}
}
