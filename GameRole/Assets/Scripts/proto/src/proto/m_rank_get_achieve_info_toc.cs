namespace proto {
	public class m_rank_get_achieve_info_toc : Message
	{
		public int err_code = 0;
		public object[] achieve_info;
		public double role_id = 0;
		public int rank = 0;
		public string role_name = null;
		public int sex = 0;
		public int category = 0;
		public string family_name = null;
		public int op_type = 0;
		public m_rank_get_achieve_info_toc() {
		}
		public override string getMethodName() {
			return "rank_get_achieve_info";
		}
		public override string getClassName() {
			return "m_rank_get_achieve_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"achieve_info", "array", "p_achieve_info"},new string[] {"role_id", "double", "null"},new string[] {"rank", "int", "null"},new string[] {"role_name", "string", "null"},new string[] {"sex", "int", "null"},new string[] {"category", "int", "null"},new string[] {"family_name", "string", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
