namespace proto {
	public class m_family_info_change_toc : Message
	{
		public object[] changes;
		public m_family_info_change_toc() {
		}
		public override string getMethodName() {
			return "family_info_change";
		}
		public override string getClassName() {
			return "m_family_info_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"changes", "array", "p_family_info_change"}};
		}
	}
}
