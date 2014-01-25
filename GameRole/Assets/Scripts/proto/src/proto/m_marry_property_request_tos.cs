namespace proto {
	public class m_marry_property_request_tos : Message
	{
		public int love_rate = 0;
		public int sweet_rate = 0;
		public int house_own = 0;
		public int skill_own = 0;
		public m_marry_property_request_tos() {
		}
		public override string getMethodName() {
			return "marry_property_request";
		}
		public override string getClassName() {
			return "m_marry_property_request_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"love_rate", "int", "null"},new string[] {"sweet_rate", "int", "null"},new string[] {"house_own", "int", "null"},new string[] {"skill_own", "int", "null"}};
		}
	}
}
