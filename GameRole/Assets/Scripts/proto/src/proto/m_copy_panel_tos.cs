namespace proto {
	public class m_copy_panel_tos : Message
	{
		public int map_id = 0;
		public m_copy_panel_tos() {
		}
		public override string getMethodName() {
			return "copy_panel";
		}
		public override string getClassName() {
			return "m_copy_panel_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"}};
		}
	}
}
