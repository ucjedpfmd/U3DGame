namespace proto {
	public class m_family_info_icon_toc : Message
	{
		public object[] list;
		public m_family_info_icon_toc() {
		}
		public override string getMethodName() {
			return "family_info_icon";
		}
		public override string getClassName() {
			return "m_family_info_icon_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_key_value"}};
		}
	}
}
