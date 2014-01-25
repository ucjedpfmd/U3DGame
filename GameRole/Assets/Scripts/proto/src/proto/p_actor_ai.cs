namespace proto {
	public class p_actor_ai : Message
	{
		public int ai_id = 0;
		public int ai_max_times = 0;
		public int ai_trigger_times = 0;
		public int ai_state = 0;
		public object[] ai_actions;
		public p_actor_ai() {
		}
		public override string getClassName() {
			return "p_actor_ai";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ai_id", "int", "null"},new string[] {"ai_max_times", "int", "null"},new string[] {"ai_trigger_times", "int", "null"},new string[] {"ai_state", "int", "null"},new string[] {"ai_actions", "array", "p_ai_action"}};
		}
	}
}
