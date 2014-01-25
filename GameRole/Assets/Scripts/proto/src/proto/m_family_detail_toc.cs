namespace proto {
	public class m_family_detail_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_family_info content = null;
		public m_family_detail_toc() {
		}
		public override string getMethodName() {
			return "family_detail";
		}
		public override string getClassName() {
			return "m_family_detail_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"content", "p_family_info", "null"}};
		}
	}
}
