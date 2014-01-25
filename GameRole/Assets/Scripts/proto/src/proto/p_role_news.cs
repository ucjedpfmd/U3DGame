namespace proto {
	public class p_role_news : Message
	{
		public int event_id = 0;
		public int status = 0;
		public int complete_time = 0;
		public p_role_news() {
		}
		public override string getClassName() {
			return "p_role_news";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"event_id", "int", "null"},new string[] {"status", "int", "null"},new string[] {"complete_time", "int", "null"}};
		}
	}
}
