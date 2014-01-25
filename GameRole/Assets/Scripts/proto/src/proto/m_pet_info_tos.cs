namespace proto {
	public class m_pet_info_tos : Message
	{
		public double target_role_id = 0;
		public object[] pet_ids;
		public m_pet_info_tos() {
		}
		public override string getMethodName() {
			return "pet_info";
		}
		public override string getClassName() {
			return "m_pet_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_role_id", "double", "null"},new string[] {"pet_ids", "array", "double"}};
		}
	}
}
