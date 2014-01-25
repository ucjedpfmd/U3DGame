namespace proto {
	public class m_pet_soul_bag_toc : Message
	{
		public int err_code = 0;
		public p_role_pet_soul soul_info = null;
		public int bottle_exp = 0;
		public m_pet_soul_bag_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_bag";
		}
		public override string getClassName() {
			return "m_pet_soul_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"soul_info", "p_role_pet_soul", "null"},new string[] {"bottle_exp", "int", "null"}};
		}
	}
}
