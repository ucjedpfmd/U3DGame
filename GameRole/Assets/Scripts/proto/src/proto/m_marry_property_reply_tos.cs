namespace proto {
	public class m_marry_property_reply_tos : Message
	{
		public bool agree = true;
		public double req_id = 0;
		public m_marry_property_reply_tos() {
		}
		public override string getMethodName() {
			return "marry_property_reply";
		}
		public override string getClassName() {
			return "m_marry_property_reply_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"agree", "bool", "null"},new string[] {"req_id", "double", "null"}};
		}
	}
}
