namespace proto {
	public class p_pet_arena_ranking_recent : Message
	{
		public int role_id = 0;
		public string role_name = null;
		public string rank_role_name = null;
		public int new_rank = 0;
		public int result = 0;
		public int time = 0;
		public p_pet_arena_ranking_recent() {
		}
		public override string getClassName() {
			return "p_pet_arena_ranking_recent";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "int", "null"},new string[] {"role_name", "string", "null"},new string[] {"rank_role_name", "string", "null"},new string[] {"new_rank", "int", "null"},new string[] {"result", "int", "null"},new string[] {"time", "int", "null"}};
		}
	}
}
