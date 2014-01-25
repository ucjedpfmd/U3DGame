namespace proto {
	public class m_skill_learn_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_role_skill skill = null;
		public int silver = 0;
		public int gold = 0;
		public m_skill_learn_toc() {
		}
		public override string getMethodName() {
			return "skill_learn";
		}
		public override string getClassName() {
			return "m_skill_learn_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"skill", "p_role_skill", "null"},new string[] {"silver", "int", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
