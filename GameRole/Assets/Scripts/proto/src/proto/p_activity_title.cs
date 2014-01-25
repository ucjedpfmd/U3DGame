namespace proto {
	public class p_activity_title : Message
	{
		public int key = 0;
		public string desc = null;
		public string title = null;
		public bool can_reward = true;
		public p_activity_title() {
		}
		public override string getClassName() {
			return "p_activity_title";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"key", "int", "null"},new string[] {"desc", "string", "null"},new string[] {"title", "string", "null"},new string[] {"can_reward", "bool", "null"}};
		}
	}
}
