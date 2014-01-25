namespace proto {
	public class m_event_notice_toc : Message
	{
		public int type = 0;
		public m_event_notice_toc() {
		}
		public override string getMethodName() {
			return "event_notice";
		}
		public override string getClassName() {
			return "m_event_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
