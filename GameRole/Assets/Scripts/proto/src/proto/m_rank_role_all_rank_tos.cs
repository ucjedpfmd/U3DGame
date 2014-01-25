namespace proto {
	public class m_rank_role_all_rank_tos : Message
	{
		public double role_id = 0;
		public m_rank_role_all_rank_tos() {
		}
		public override string getMethodName() {
			return "rank_role_all_rank";
		}
		public override string getClassName() {
			return "m_rank_role_all_rank_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
