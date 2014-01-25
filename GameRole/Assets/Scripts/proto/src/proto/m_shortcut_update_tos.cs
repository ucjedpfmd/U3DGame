namespace proto {
	public class m_shortcut_update_tos : Message
	{
		public object[] shortcut_list;
		public int selected = 0;
		public m_shortcut_update_tos() {
		}
		public override string getMethodName() {
			return "shortcut_update";
		}
		public override string getClassName() {
			return "m_shortcut_update_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shortcut_list", "array", "p_shortcut"},new string[] {"selected", "int", "null"}};
		}
	}
}
