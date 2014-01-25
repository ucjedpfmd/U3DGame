namespace proto {
	public class m_family_activity_update_toc : Message
	{
		public int type = 0;
		public object[] logs;
		public p_family_tree tree_info = null;
		public m_family_activity_update_toc() {
		}
		public override string getMethodName() {
			return "family_activity_update";
		}
		public override string getClassName() {
			return "m_family_activity_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"logs", "array", "p_family_tree_log"},new string[] {"tree_info", "p_family_tree", "null"}};
		}
	}
}
