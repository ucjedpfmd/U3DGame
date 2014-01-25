namespace proto {
	public class p_activity_info : Message
	{
		public int id = 0;
		public int type = 0;
		public int order_id = 0;
		public int status = 0;
		public int done_times = 0;
		public p_activity_info() {
		}
		public override string getClassName() {
			return "p_activity_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"order_id", "int", "null"},new string[] {"status", "int", "null"},new string[] {"done_times", "int", "null"}};
		}
	}
}
