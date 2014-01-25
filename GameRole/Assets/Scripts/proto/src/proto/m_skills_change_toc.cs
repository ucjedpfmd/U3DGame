namespace proto {
	public class m_skills_change_toc : Message
	{
		public object[] skills;
		public m_skills_change_toc() {
		}
		public override string getMethodName() {
			return "skills_change";
		}
		public override string getClassName() {
			return "m_skills_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"skills", "array", "p_role_skill"}};
		}
	}
}
