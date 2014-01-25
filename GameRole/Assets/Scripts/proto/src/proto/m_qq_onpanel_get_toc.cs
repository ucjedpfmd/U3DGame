namespace proto {
	public class m_qq_onpanel_get_toc : Message
	{
		public int err_code = 0;
		public m_qq_onpanel_get_toc() {
		}
		public override string getMethodName() {
			return "qq_onpanel_get";
		}
		public override string getClassName() {
			return "m_qq_onpanel_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
