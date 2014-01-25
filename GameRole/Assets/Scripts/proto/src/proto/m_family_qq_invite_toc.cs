namespace proto {
	public class m_family_qq_invite_toc : Message
	{
		public int err_code = 0;
		public object[] openids;
		public string family_openid = null;
		public m_family_qq_invite_toc() {
		}
		public override string getMethodName() {
			return "family_qq_invite";
		}
		public override string getClassName() {
			return "m_family_qq_invite_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"openids", "array", "string"},new string[] {"family_openid", "string", "null"}};
		}
	}
}
