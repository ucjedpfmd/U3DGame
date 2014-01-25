namespace proto {
	public class m_marry_feast_guide_info_toc : Message
	{
		public int err_code = 0;
		public int love = 0;
		public int bless = 0;
		public object[] names;
		public object[] lords;
		public m_marry_feast_guide_info_toc() {
		}
		public override string getMethodName() {
			return "marry_feast_guide_info";
		}
		public override string getClassName() {
			return "m_marry_feast_guide_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"love", "int", "null"},new string[] {"bless", "int", "null"},new string[] {"names", "array", "string"},new string[] {"lords", "array", "double"}};
		}
	}
}
