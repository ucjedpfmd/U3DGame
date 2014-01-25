namespace proto {
	public class m_marry_publish_info_toc : Message
	{
		public int err_code = 0;
		public bool is_lord = true;
		public int need_gold = 0;
		public int do_num = 0;
		public int total_num = 0;
		public int do_my_times = 0;
		public m_marry_publish_info_toc() {
		}
		public override string getMethodName() {
			return "marry_publish_info";
		}
		public override string getClassName() {
			return "m_marry_publish_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"is_lord", "bool", "null"},new string[] {"need_gold", "int", "null"},new string[] {"do_num", "int", "null"},new string[] {"total_num", "int", "null"},new string[] {"do_my_times", "int", "null"}};
		}
	}
}
