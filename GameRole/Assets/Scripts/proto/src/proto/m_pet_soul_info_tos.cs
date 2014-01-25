namespace proto {
	public class m_pet_soul_info_tos : Message
	{
		public double target_role = 0;
		public int index = 0;
		public m_pet_soul_info_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_info";
		}
		public override string getClassName() {
			return "m_pet_soul_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_role", "double", "null"},new string[] {"index", "int", "null"}};
		}
	}
}
