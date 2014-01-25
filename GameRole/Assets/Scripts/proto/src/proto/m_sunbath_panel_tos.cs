namespace proto {
	public class m_sunbath_panel_tos : Message
	{
		public int op_type = 0;
		public m_sunbath_panel_tos() {
		}
		public override string getMethodName() {
			return "sunbath_panel";
		}
		public override string getClassName() {
			return "m_sunbath_panel_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"}};
		}
	}
}
