namespace proto {
	public class p_activity_copy_times : Message
	{
		public int group_id = 0;
		public int times = 0;
		public int max_times = 0;
		public int order_id = 0;
		public int status = 0;
		public p_activity_copy_times() {
		}
		public override string getClassName() {
			return "p_activity_copy_times";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"group_id", "int", "null"},new string[] {"times", "int", "null"},new string[] {"max_times", "int", "null"},new string[] {"order_id", "int", "null"},new string[] {"status", "int", "null"}};
		}
	}
}
