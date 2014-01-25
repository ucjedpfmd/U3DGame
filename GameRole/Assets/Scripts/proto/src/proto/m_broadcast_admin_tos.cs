namespace proto {
	public class m_broadcast_admin_tos : Message
	{
		public int id = 0;
		public int foreign_id = 0;
		public int type = 0;
		public string content = null;
		public int send_strategy = 0;
		public string start_date = null;
		public string end_date = null;
		public string start_time = null;
		public string end_time = null;
		public int interval = 0;
		public m_broadcast_admin_tos() {
		}
		public override string getMethodName() {
			return "broadcast_admin";
		}
		public override string getClassName() {
			return "m_broadcast_admin_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"foreign_id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"content", "string", "null"},new string[] {"send_strategy", "int", "null"},new string[] {"start_date", "string", "null"},new string[] {"end_date", "string", "null"},new string[] {"start_time", "string", "null"},new string[] {"end_time", "string", "null"},new string[] {"interval", "int", "null"}};
		}
	}
}
