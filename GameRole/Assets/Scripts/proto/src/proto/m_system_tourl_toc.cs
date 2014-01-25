namespace proto {
	public class m_system_tourl_toc : Message
	{
		public string url = null;
		public m_system_tourl_toc() {
		}
		public override string getMethodName() {
			return "system_tourl";
		}
		public override string getClassName() {
			return "m_system_tourl_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"url", "string", "null"}};
		}
	}
}
