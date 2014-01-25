namespace proto {
	public class m_pet_change_name_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public double pet_id = 0;
		public string new_name = null;
		public m_pet_change_name_toc() {
		}
		public override string getMethodName() {
			return "pet_change_name";
		}
		public override string getClassName() {
			return "m_pet_change_name_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"pet_id", "double", "null"},new string[] {"new_name", "string", "null"}};
		}
	}
}
