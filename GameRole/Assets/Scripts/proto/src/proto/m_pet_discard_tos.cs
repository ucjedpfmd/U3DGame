namespace proto {
	public class m_pet_discard_tos : Message
	{
		public double pet_id = 0;
		public m_pet_discard_tos() {
		}
		public override string getMethodName() {
			return "pet_discard";
		}
		public override string getClassName() {
			return "m_pet_discard_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"}};
		}
	}
}
