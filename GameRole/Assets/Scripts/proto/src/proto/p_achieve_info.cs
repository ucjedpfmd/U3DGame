namespace proto {
	public class p_achieve_info : Message
	{
		public int achieve_id = 0;
		public int type = 0;
		public int state = 0;
		public int gain_time = 0;
		public object[] cur_progress;
		public int total_progress = 0;
		public int color = 0;
		public p_achieve_reward reward = null;
		public p_achieve_info() {
		}
		public override string getClassName() {
			return "p_achieve_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"achieve_id", "int", "null"},new string[] {"type", "int", "null"},new string[] {"state", "int", "null"},new string[] {"gain_time", "int", "null"},new string[] {"cur_progress", "array", "int"},new string[] {"total_progress", "int", "null"},new string[] {"color", "int", "null"},new string[] {"reward", "p_achieve_reward", "null"}};
		}
	}
}
