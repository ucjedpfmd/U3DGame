namespace proto {
	public class m_pet_skill_bag_toc : Message
	{
		public int err_code = 0;
		public p_role_pet_skill skill_info = null;
		public m_pet_skill_bag_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_bag";
		}
		public override string getClassName() {
			return "m_pet_skill_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"skill_info", "p_role_pet_skill", "null"}};
		}
	}
}
