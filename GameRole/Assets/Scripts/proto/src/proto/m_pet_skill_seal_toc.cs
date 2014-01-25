namespace proto {
	public class m_pet_skill_seal_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_pet_skill update_skill = null;
		public int gold = 0;
		public m_pet_skill_seal_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_seal";
		}
		public override string getClassName() {
			return "m_pet_skill_seal_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"update_skill", "p_pet_skill", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
