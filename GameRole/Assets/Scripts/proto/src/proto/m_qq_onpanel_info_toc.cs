namespace proto {
	public class m_qq_onpanel_info_toc : Message
	{
		public int state = 0;
		public object[] goods;
		public m_qq_onpanel_info_toc() {
		}
		public override string getMethodName() {
			return "qq_onpanel_info";
		}
		public override string getClassName() {
			return "m_qq_onpanel_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"goods", "array", "p_kv"}};
		}
	}
}
