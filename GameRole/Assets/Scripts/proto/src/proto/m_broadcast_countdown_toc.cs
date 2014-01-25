namespace proto {
	public class m_broadcast_countdown_toc : Message
	{
		public int type = 0;
		public int sub_type = 0;
		public int id = 0;
		public string content = null;
		public int countdown_time = 0;
		public int current_countdown_time = 0;
		public m_broadcast_countdown_toc() {
		}
		public override string getMethodName() {
			return "broadcast_countdown";
		}
		public override string getClassName() {
			return "m_broadcast_countdown_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"},new string[] {"sub_type", "int", "null"},new string[] {"id", "int", "null"},new string[] {"content", "string", "null"},new string[] {"countdown_time", "int", "null"},new string[] {"current_countdown_time", "int", "null"}};
		}
	}
}
