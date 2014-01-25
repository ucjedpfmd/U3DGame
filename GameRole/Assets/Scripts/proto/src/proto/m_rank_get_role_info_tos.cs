namespace proto {
	public class m_rank_get_role_info_tos : Message
	{
		public int rank_id = 0;
		public double role_id = 0;
		public m_rank_get_role_info_tos() {
		}
		public override string getMethodName() {
			return "rank_get_role_info";
		}
		public override string getClassName() {
			return "m_rank_get_role_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"role_id", "double", "null"}};
		}
	}
}
