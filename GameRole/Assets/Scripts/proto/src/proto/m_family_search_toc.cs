namespace proto {
	public class m_family_search_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] family_briefs;
		public m_family_search_toc() {
		}
		public override string getMethodName() {
			return "family_search";
		}
		public override string getClassName() {
			return "m_family_search_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"family_briefs", "array", "p_family_brief"}};
		}
	}
}
