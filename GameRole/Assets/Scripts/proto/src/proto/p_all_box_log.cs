namespace proto {
	public class p_all_box_log : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public int discover_date = 0;
		public int discover_times = 0;
		public object[] goods_lists;
		public p_all_box_log() {
		}
		public override string getClassName() {
			return "p_all_box_log";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"},new string[] {"discover_date", "int", "null"},new string[] {"discover_times", "int", "null"},new string[] {"goods_lists", "array", "p_box_goods"}};
		}
	}
}
