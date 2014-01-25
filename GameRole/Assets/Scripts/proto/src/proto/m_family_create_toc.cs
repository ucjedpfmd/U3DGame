namespace proto {
	public class m_family_create_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_family_info family_info = null;
		public int silver = 0;
		public m_family_create_toc() {
		}
		public override string getMethodName() {
			return "family_create";
		}
		public override string getClassName() {
			return "m_family_create_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"family_info", "p_family_info", "null"},new string[] {"silver", "int", "null"}};
		}
	}
}
