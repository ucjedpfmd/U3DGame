namespace proto {
	public class m_family_brief_toc : Message
	{
		public int err_code = 0;
		public p_family_brief family_brief = null;
		public m_family_brief_toc() {
		}
		public override string getMethodName() {
			return "family_brief";
		}
		public override string getClassName() {
			return "m_family_brief_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"family_brief", "p_family_brief", "null"}};
		}
	}
}
