namespace proto {
	public class m_role_cross_panel_toc : Message
	{
		public object[] lines;
		public m_role_cross_panel_toc() {
		}
		public override string getMethodName() {
			return "role_cross_panel";
		}
		public override string getClassName() {
			return "m_role_cross_panel_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"lines", "array", "p_line"}};
		}
	}
}
