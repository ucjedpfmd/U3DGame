namespace proto {
	public class m_cross_miss_update_toc : Message
	{
		public object[] miss_del;
		public object[] miss_update;
		public m_cross_miss_update_toc() {
		}
		public override string getMethodName() {
			return "cross_miss_update";
		}
		public override string getClassName() {
			return "m_cross_miss_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"miss_del", "array", "int"},new string[] {"miss_update", "array", "p_cross_miss_info"}};
		}
	}
}
