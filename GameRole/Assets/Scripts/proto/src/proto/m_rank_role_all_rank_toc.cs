namespace proto {
	public class m_rank_role_all_rank_toc : Message
	{
		public int err_code = 0;
		public object[] role_all_ranks;
		public m_rank_role_all_rank_toc() {
		}
		public override string getMethodName() {
			return "rank_role_all_rank";
		}
		public override string getClassName() {
			return "m_rank_role_all_rank_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"role_all_ranks", "array", "p_role_rank"}};
		}
	}
}
