namespace proto {
	public class m_pet_skill_tidy_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_pet update_pet = null;
		public p_role_pet_skill role_pet_skill = null;
		public object[] bag_ids;
		public m_pet_skill_tidy_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_tidy";
		}
		public override string getClassName() {
			return "m_pet_skill_tidy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"update_pet", "p_pet", "null"},new string[] {"role_pet_skill", "p_role_pet_skill", "null"},new string[] {"bag_ids", "array", "int"}};
		}
	}
}
