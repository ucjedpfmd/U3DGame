namespace proto {
	public class m_pet_weal_get_toc : Message
	{
		public int err_code = 0;
		public p_pet_skill pet_skill = null;
		public m_pet_weal_get_toc() {
		}
		public override string getMethodName() {
			return "pet_weal_get";
		}
		public override string getClassName() {
			return "m_pet_weal_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_skill", "p_pet_skill", "null"}};
		}
	}
}
