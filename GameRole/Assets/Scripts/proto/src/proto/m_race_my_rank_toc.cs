namespace proto {
	public class m_race_my_rank_toc : Message
	{
		public double role_id = 0;
		public object[] ranks;
		public m_race_my_rank_toc() {
		}
		public override string getMethodName() {
			return "race_my_rank";
		}
		public override string getClassName() {
			return "m_race_my_rank_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"ranks", "array", "p_rank_info"}};
		}
	}
}
