namespace proto {
	public class p_cross_miss_info : Message
	{
		public int miss_id = 0;
		public object[] listen;
		public int status = 0;
		public int color = 0;
		public int succ_times = 0;
		public p_cross_miss_info() {
		}
		public override string getClassName() {
			return "p_cross_miss_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"miss_id", "int", "null"},new string[] {"listen", "array", "p_cross_listen"},new string[] {"status", "int", "null"},new string[] {"color", "int", "null"},new string[] {"succ_times", "int", "null"}};
		}
	}
}
