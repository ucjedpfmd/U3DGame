namespace proto {
	public class m_role_verify_info_toc : Message
	{
		public string verify_code = null;
		public object[] rewards;
		public m_role_verify_info_toc() {
		}
		public override string getMethodName() {
			return "role_verify_info";
		}
		public override string getClassName() {
			return "m_role_verify_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"verify_code", "string", "null"},new string[] {"rewards", "array", "p_kv"}};
		}
	}
}
