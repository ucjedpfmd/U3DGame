namespace proto {
	public class p_role_enemy : Message
	{
		public double actor_id = 0;
		public double last_att_time = 0;
		public p_role_enemy() {
		}
		public override string getClassName() {
			return "p_role_enemy";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"actor_id", "double", "null"},new string[] {"last_att_time", "double", "null"}};
		}
	}
}
