namespace proto {
	public class m_pet_soul_info_toc : Message
	{
		public int err_code = 0;
		public double target_role = 0;
		public p_pet_soul pet_soul = null;
		public double pet_id = 0;
		public string pet_name = null;
		public m_pet_soul_info_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_info";
		}
		public override string getClassName() {
			return "m_pet_soul_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"target_role", "double", "null"},new string[] {"pet_soul", "p_pet_soul", "null"},new string[] {"pet_id", "double", "null"},new string[] {"pet_name", "string", "null"}};
		}
	}
}
