namespace proto {
	public class m_skill_getskills_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] skills;
		public object[] skill_times;
		public m_skill_getskills_toc() {
		}
		public override string getMethodName() {
			return "skill_getskills";
		}
		public override string getClassName() {
			return "m_skill_getskills_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"skills", "array", "p_role_skill"},new string[] {"skill_times", "array", "p_skill_time"}};
		}
	}
}
