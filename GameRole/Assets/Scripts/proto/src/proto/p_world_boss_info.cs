namespace proto {
	public class p_world_boss_info : Message
	{
		public int boss_id = 0;
		public double born_time = 0;
		public double open_role_id = 0;
		public string open_role_name = null;
		public p_world_boss_info() {
		}
		public override string getClassName() {
			return "p_world_boss_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"boss_id", "int", "null"},new string[] {"born_time", "double", "null"},new string[] {"open_role_id", "double", "null"},new string[] {"open_role_name", "string", "null"}};
		}
	}
}
