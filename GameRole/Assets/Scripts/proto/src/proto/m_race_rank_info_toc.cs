namespace proto {
	public class m_race_rank_info_toc : Message
	{
		public object[] top5;
		public m_race_rank_info_toc() {
		}
		public override string getMethodName() {
			return "race_rank_info";
		}
		public override string getClassName() {
			return "m_race_rank_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"top5", "array", "p_rank_info"}};
		}
	}
}
