namespace proto {
	public class m_collect_remove_toc : Message
	{
		public object[] grafts;
		public m_collect_remove_toc() {
		}
		public override string getMethodName() {
			return "collect_remove";
		}
		public override string getClassName() {
			return "m_collect_remove_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"grafts", "array", "p_map_collect"}};
		}
	}
}
