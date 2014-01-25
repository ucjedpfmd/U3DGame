namespace proto {
	public class m_cross_miss_info_toc : Message
	{
		public int model = 0;
		public object[] miss_info;
		public m_cross_miss_info_toc() {
		}
		public override string getMethodName() {
			return "cross_miss_info";
		}
		public override string getClassName() {
			return "m_cross_miss_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"model", "int", "null"},new string[] {"miss_info", "array", "p_cross_miss_info"}};
		}
	}
}
