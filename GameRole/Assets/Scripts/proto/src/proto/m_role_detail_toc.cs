namespace proto {
	public class m_role_detail_toc : Message
	{
		public p_role_data role_details = null;
		public object[] bags;
		public int server_time = 0;
		public int queue_num = 0;
		public int wait_sec = 0;
		public string full_version = null;
		public m_role_detail_toc() {
		}
		public override string getMethodName() {
			return "role_detail";
		}
		public override string getClassName() {
			return "m_role_detail_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_details", "p_role_data", "null"},new string[] {"bags", "array", "p_bag_content"},new string[] {"server_time", "int", "null"},new string[] {"queue_num", "int", "null"},new string[] {"wait_sec", "int", "null"},new string[] {"full_version", "string", "null"}};
		}
	}
}
