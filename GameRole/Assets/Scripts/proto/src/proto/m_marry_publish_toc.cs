namespace proto {
	public class m_marry_publish_toc : Message
	{
		public int err_code = 0;
		public int do_num = 0;
		public int total_num = 0;
		public m_marry_publish_toc() {
		}
		public override string getMethodName() {
			return "marry_publish";
		}
		public override string getClassName() {
			return "m_marry_publish_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"do_num", "int", "null"},new string[] {"total_num", "int", "null"}};
		}
	}
}
