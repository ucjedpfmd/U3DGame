namespace proto {
	public class p_actor_buf : Message
	{
		public int buff_id = 0;
		public int remain_time = 0;
		public double actor_id = 0;
		public int actor_type = 0;
		public double from_actor_id = 0;
		public int from_actor_type = 0;
		public int start_time = 0;
		public int end_time = 0;
		public int buff_type = 0;
		public int value = 0;
		public p_actor_buf() {
		}
		public override string getClassName() {
			return "p_actor_buf";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"buff_id", "int", "null"},new string[] {"remain_time", "int", "null"},new string[] {"actor_id", "double", "null"},new string[] {"actor_type", "int", "null"},new string[] {"from_actor_id", "double", "null"},new string[] {"from_actor_type", "int", "null"},new string[] {"start_time", "int", "null"},new string[] {"end_time", "int", "null"},new string[] {"buff_type", "int", "null"},new string[] {"value", "int", "null"}};
		}
	}
}
