namespace proto {
	public class m_pet_arena_ranking_toc : Message
	{
		public int err_code = 0;
		public int challenge_times = 0;
		public int all_times = 0;
		public object[] ranking_recent;
		public object[] ranking;
		public m_pet_arena_ranking_toc() {
		}
		public override string getMethodName() {
			return "pet_arena_ranking";
		}
		public override string getClassName() {
			return "m_pet_arena_ranking_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"challenge_times", "int", "null"},new string[] {"all_times", "int", "null"},new string[] {"ranking_recent", "array", "p_pet_arena_ranking_recent"},new string[] {"ranking", "array", "p_pet_arena_rank"}};
		}
	}
}
