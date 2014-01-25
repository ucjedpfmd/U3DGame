namespace proto {
	public class p_my_box_log : Message
	{
		public int discover_date = 0;
		public int discover_times = 0;
		public object[] goods_lists;
		public p_my_box_log() {
		}
		public override string getClassName() {
			return "p_my_box_log";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"discover_date", "int", "null"},new string[] {"discover_times", "int", "null"},new string[] {"goods_lists", "array", "p_box_goods"}};
		}
	}
}
