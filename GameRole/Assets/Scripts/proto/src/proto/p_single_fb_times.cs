namespace proto {
	public class p_single_fb_times : Message
	{
		public int map_id = 0;
		public int times = 0;
		public int buy_times = 0;
		public p_single_fb_times() {
		}
		public override string getClassName() {
			return "p_single_fb_times";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"map_id", "int", "null"},new string[] {"times", "int", "null"},new string[] {"buy_times", "int", "null"}};
		}
	}
}
