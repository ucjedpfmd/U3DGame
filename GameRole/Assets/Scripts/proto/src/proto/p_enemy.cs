namespace proto {
	public class p_enemy : Message
	{
		public int actor_key = 0;
		public int total_hurt = 0;
		public int last_att_time = 0;
		public int pos = 0;
		public int state = 1;
		public p_enemy() {
		}
		public override string getClassName() {
			return "p_enemy";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_key", "int", "null"},new string[] {"total_hurt", "int", "null"},new string[] {"last_att_time", "int", "null"},new string[] {"pos", "int", "null"},new string[] {"state", "int", "null"}};
		}
	}
}
