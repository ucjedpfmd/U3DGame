namespace proto {
	public class m_marry_house_info_toc : Message
	{
		public int err_code = 0;
		public p_brief_house_info brief_house = null;
		public int last_visit_time = 0;
		public m_marry_house_info_toc() {
		}
		public override string getMethodName() {
			return "marry_house_info";
		}
		public override string getClassName() {
			return "m_marry_house_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"brief_house", "p_brief_house_info", "null"},new string[] {"last_visit_time", "int", "null"}};
		}
	}
}
