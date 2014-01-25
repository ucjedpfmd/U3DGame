namespace proto {
	public class m_rank_get_achieve_info_tos : Message
	{
		public int rank_id = 0;
		public double role_id = 0;
		public int rank = 0;
		public int op_type = 0;
		public m_rank_get_achieve_info_tos() {
		}
		public override string getMethodName() {
			return "rank_get_achieve_info";
		}
		public override string getClassName() {
			return "m_rank_get_achieve_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"rank", "int", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
