namespace proto {
	public class m_family_pet_embattle_role_info_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public object[] role_list;
		public m_family_pet_embattle_role_info_toc() {
		}
		public override string getMethodName() {
			return "family_pet_embattle_role_info";
		}
		public override string getClassName() {
			return "m_family_pet_embattle_role_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"role_list", "array", "p_family_pet_embattle_role"}};
		}
	}
}
