namespace proto {
	public class m_family_bind_qq_tos : Message
	{
		public bool bind = true;
		public string qq_group = null;
		public string family_openid = null;
		public m_family_bind_qq_tos() {
		}
		public override string getMethodName() {
			return "family_bind_qq";
		}
		public override string getClassName() {
			return "m_family_bind_qq_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bind", "bool", "null"},new string[] {"qq_group", "string", "null"},new string[] {"family_openid", "string", "null"}};
		}
	}
}
