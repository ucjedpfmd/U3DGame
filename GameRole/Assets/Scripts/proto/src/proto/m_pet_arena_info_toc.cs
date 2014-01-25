namespace proto {
	public class m_pet_arena_info_toc : Message
	{
		public int err_code = 0;
		public double role_id = 0;
		public int rank_id = 0;
		public int pet_power = 0;
		public int arena_score = 0;
		public int challenge_times = 0;
		public int all_times = 0;
		public int refresh_time = 0;
		public object[] challenge;
		public object[] recent_info;
		public m_pet_arena_info_toc() {
		}
		public override string getMethodName() {
			return "pet_arena_info";
		}
		public override string getClassName() {
			return "m_pet_arena_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"rank_id", "int", "null"},new string[] {"pet_power", "int", "null"},new string[] {"arena_score", "int", "null"},new string[] {"challenge_times", "int", "null"},new string[] {"all_times", "int", "null"},new string[] {"refresh_time", "int", "null"},new string[] {"challenge", "array", "p_pet_arena_rank"},new string[] {"recent_info", "array", "p_pet_arena_recent"}};
		}
	}
}
