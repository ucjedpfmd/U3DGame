namespace proto {
	public class m_family_tree_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_family_tree tree_info = null;
		public int shake_times = 0;
		public int water_times = 0;
		public m_family_tree_info_toc() {
		}
		public override string getMethodName() {
			return "family_tree_info";
		}
		public override string getClassName() {
			return "m_family_tree_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"tree_info", "p_family_tree", "null"},new string[] {"shake_times", "int", "null"},new string[] {"water_times", "int", "null"}};
		}
	}
}
