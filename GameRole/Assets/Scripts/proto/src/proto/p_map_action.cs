namespace proto {
	public class p_map_action : Message
	{
		public int action_id = 0;
		public double trigger_msecond = 0;
		public int repeated_times = 0;
		public bool progress_bar = false;
		public bool can_interrupt = false;
		public int affect_offset = 0;
		public p_map_action() {
		}
		public override string getClassName() {
			return "p_map_action";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_id", "int", "null"},new string[] {"trigger_msecond", "double", "null"},new string[] {"repeated_times", "int", "null"},new string[] {"progress_bar", "bool", "null"},new string[] {"can_interrupt", "bool", "null"},new string[] {"affect_offset", "int", "null"}};
		}
	}
}
