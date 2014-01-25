namespace proto {
	public class m_role_attr_change_toc : Message
	{
		public double roleid = 0;
		public object[] changes;
		public m_role_attr_change_toc() {
		}
		public override string getMethodName() {
			return "role_attr_change";
		}
		public override string getClassName() {
			return "m_role_attr_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"},new string[] {"changes", "array", "p_role_attr_change"}};
		}
	}
}
