namespace proto {
	public class m_common_begin_notice_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int type = 0;
		public int begin_time = 0;
		public int end_time = 0;
		public int state = 0;
		public m_common_begin_notice_toc() {
		}
		public override string getMethodName() {
			return "common_begin_notice";
		}
		public override string getClassName() {
			return "m_common_begin_notice_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"type", "int", "null"},new string[] {"begin_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
