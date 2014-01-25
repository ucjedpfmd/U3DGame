namespace proto {
	public class m_rank_get_rank_toc : Message
	{
		public int err_code = 0;
		public int rank_id = 0;
		public object[] rows;
		public int open_days = 0;
		public int now_time = 0;
		public m_rank_get_rank_toc() {
		}
		public override string getMethodName() {
			return "rank_get_rank";
		}
		public override string getClassName() {
			return "m_rank_get_rank_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"rank_id", "int", "null"},new string[] {"rows", "array", "p_rank_row"},new string[] {"open_days", "int", "null"},new string[] {"now_time", "int", "null"}};
		}
	}
}
