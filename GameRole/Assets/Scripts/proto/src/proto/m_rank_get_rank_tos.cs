namespace proto {
	public class m_rank_get_rank_tos : Message
	{
		public int rank_id = 0;
		public m_rank_get_rank_tos() {
		}
		public override string getMethodName() {
			return "rank_get_rank";
		}
		public override string getClassName() {
			return "m_rank_get_rank_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"}};
		}
	}
}
