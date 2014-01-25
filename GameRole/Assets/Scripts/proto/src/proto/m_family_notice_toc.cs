namespace proto {
	public class m_family_notice_toc : Message
	{
		public int notice_type = 0;
		public string notice_msg = null;
		public int notice_value = 0;
		public m_family_notice_toc() {
		}
		public override string getMethodName() {
			return "family_notice";
		}
		public override string getClassName() {
			return "m_family_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"notice_type", "int", "null"},new string[] {"notice_msg", "string", "null"},new string[] {"notice_value", "int", "null"}};
		}
	}
}
