namespace proto {
	public class m_shortcut_init_toc : Message
	{
		public object[] shortcut_list;
		public int selected = 0;
		public m_shortcut_init_toc() {
		}
		public override string getMethodName() {
			return "shortcut_init";
		}
		public override string getClassName() {
			return "m_shortcut_init_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shortcut_list", "array", "p_shortcut"},new string[] {"selected", "int", "null"}};
		}
	}
}
