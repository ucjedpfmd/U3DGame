namespace proto {
	public class m_marry_property_info_toc : Message
	{
		public int err_code = 0;
		public int state = 0;
		public double req_id = 0;
		public int love_rate = 0;
		public int sweet_rate = 0;
		public int house_own = 0;
		public int skill_own = 0;
		public m_marry_property_info_toc() {
		}
		public override string getMethodName() {
			return "marry_property_info";
		}
		public override string getClassName() {
			return "m_marry_property_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"state", "int", "null"},new string[] {"req_id", "double", "null"},new string[] {"love_rate", "int", "null"},new string[] {"sweet_rate", "int", "null"},new string[] {"house_own", "int", "null"},new string[] {"skill_own", "int", "null"}};
		}
	}
}
