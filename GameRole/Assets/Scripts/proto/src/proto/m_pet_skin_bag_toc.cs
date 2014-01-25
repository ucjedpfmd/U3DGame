namespace proto {
	public class m_pet_skin_bag_toc : Message
	{
		public int err_code = 0;
		public p_role_pet_skin skin_info = null;
		public m_pet_skin_bag_toc() {
		}
		public override string getMethodName() {
			return "pet_skin_bag";
		}
		public override string getClassName() {
			return "m_pet_skin_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"skin_info", "p_role_pet_skin", "null"}};
		}
	}
}
