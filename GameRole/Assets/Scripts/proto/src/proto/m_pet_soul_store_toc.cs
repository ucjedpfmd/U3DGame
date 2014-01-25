namespace proto {
	public class m_pet_soul_store_toc : Message
	{
		public int err_code = 0;
		public int bottle_exp = 0;
		public m_pet_soul_store_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_store";
		}
		public override string getClassName() {
			return "m_pet_soul_store_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"bottle_exp", "int", "null"}};
		}
	}
}
