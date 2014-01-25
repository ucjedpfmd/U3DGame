namespace proto {
	public class m_pet_soul_add_exp_toc : Message
	{
		public int err_code = 0;
		public int add_exp = 0;
		public int bottle_exp = 0;
		public p_pet_soul new_pet_soul = null;
		public m_pet_soul_add_exp_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_add_exp";
		}
		public override string getClassName() {
			return "m_pet_soul_add_exp_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"add_exp", "int", "null"},new string[] {"bottle_exp", "int", "null"},new string[] {"new_pet_soul", "p_pet_soul", "null"}};
		}
	}
}
