namespace proto {
	public class m_pet_discard_toc : Message
	{
		public int err_code = 0;
		public p_role_pet_bag bag_info = null;
		public double discard_pet_id = 0;
		public int pet_skill_exp = 0;
		public m_pet_discard_toc() {
		}
		public override string getMethodName() {
			return "pet_discard";
		}
		public override string getClassName() {
			return "m_pet_discard_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"bag_info", "p_role_pet_bag", "null"},new string[] {"discard_pet_id", "double", "null"},new string[] {"pet_skill_exp", "int", "null"}};
		}
	}
}
