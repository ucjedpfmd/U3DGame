namespace proto {
	public class m_pet_soul_state_mod_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_pet_soul update_soul = null;
		public int silver = 0;
		public m_pet_soul_state_mod_toc() {
		}
		public override string getMethodName() {
			return "pet_soul_state_mod";
		}
		public override string getClassName() {
			return "m_pet_soul_state_mod_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"update_soul", "p_pet_soul", "null"},new string[] {"silver", "int", "null"}};
		}
	}
}
