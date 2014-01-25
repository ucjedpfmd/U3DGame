namespace proto {
	public class m_pet_extend_bag_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_role_pet_bag bag_info = null;
		public int gold = 0;
		public m_pet_extend_bag_toc() {
		}
		public override string getMethodName() {
			return "pet_extend_bag";
		}
		public override string getClassName() {
			return "m_pet_extend_bag_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"bag_info", "p_role_pet_bag", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
