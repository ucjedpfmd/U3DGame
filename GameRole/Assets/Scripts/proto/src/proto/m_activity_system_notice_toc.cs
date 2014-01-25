namespace proto {
	public class m_activity_system_notice_toc : Message
	{
		public string title1 = null;
		public string title2 = null;
		public string notice = null;
		public m_activity_system_notice_toc() {
		}
		public override string getMethodName() {
			return "activity_system_notice";
		}
		public override string getClassName() {
			return "m_activity_system_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"title1", "string", "null"},new string[] {"title2", "string", "null"},new string[] {"notice", "string", "null"}};
		}
	}
}
