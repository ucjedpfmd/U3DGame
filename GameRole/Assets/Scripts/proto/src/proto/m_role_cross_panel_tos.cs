namespace proto {
	public class m_role_cross_panel_tos : Message
	{
		public int op_type = 0;
		public m_role_cross_panel_tos() {
		}
		public override string getMethodName() {
			return "role_cross_panel";
		}
		public override string getClassName() {
			return "m_role_cross_panel_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
