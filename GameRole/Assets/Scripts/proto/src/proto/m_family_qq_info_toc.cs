namespace proto {
	public class m_family_qq_info_toc : Message
	{
		public int err_code = 0;
		public p_family_qq qq_info = null;
		public m_family_qq_info_toc() {
		}
		public override string getMethodName() {
			return "family_qq_info";
		}
		public override string getClassName() {
			return "m_family_qq_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"qq_info", "p_family_qq", "null"}};
		}
	}
}
