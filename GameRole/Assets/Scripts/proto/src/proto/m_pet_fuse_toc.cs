namespace proto {
	public class m_pet_fuse_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] delete_pets;
		public p_pet new_pet = null;
		public p_role_pet_bag update_role_bag = null;
		public int need_state = 0;
		public m_pet_fuse_toc() {
		}
		public override string getMethodName() {
			return "pet_fuse";
		}
		public override string getClassName() {
			return "m_pet_fuse_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"delete_pets", "array", "p_pet"},new string[] {"new_pet", "p_pet", "null"},new string[] {"update_role_bag", "p_role_pet_bag", "null"},new string[] {"need_state", "int", "null"}};
		}
	}
}
