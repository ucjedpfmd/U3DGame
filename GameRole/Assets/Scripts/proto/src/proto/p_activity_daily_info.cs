namespace proto {
	public class p_activity_daily_info : Message
	{
		public int id = 0;
		public int order_id = 0;
		public int current_times = 0;
		public p_activity_daily_info() {
		}
		public override string getClassName() {
			return "p_activity_daily_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"order_id", "int", "null"},new string[] {"current_times", "int", "null"}};
		}
	}
}
