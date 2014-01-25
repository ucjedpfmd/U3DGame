namespace proto {
	public class p_family_tree : Message
	{
		public int state = 0;
		public int color = 1;
		public int water_times = 0;
		public object[] logs;
		public p_family_tree() {
		}
		public override string getClassName() {
			return "p_family_tree";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"color", "int", "null"},new string[] {"water_times", "int", "null"},new string[] {"logs", "array", "p_family_tree_log"}};
		}
	}
}
