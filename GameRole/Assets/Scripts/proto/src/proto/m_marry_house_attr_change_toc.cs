namespace proto {
	public class m_marry_house_attr_change_toc : Message
	{
		public object[] props;
		public m_marry_house_attr_change_toc() {
		}
		public override string getMethodName() {
			return "marry_house_attr_change";
		}
		public override string getClassName() {
			return "m_marry_house_attr_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"props", "array", "p_add_prop"}};
		}
	}
}
