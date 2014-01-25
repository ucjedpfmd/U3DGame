namespace proto {
	public class m_marry_info_attr_change_toc : Message
	{
		public object[] update;
		public m_marry_info_attr_change_toc() {
		}
		public override string getMethodName() {
			return "marry_info_attr_change";
		}
		public override string getClassName() {
			return "m_marry_info_attr_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"update", "array", "p_key_value"}};
		}
	}
}
