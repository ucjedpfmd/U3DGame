namespace proto {
	public class m_rank_get_pet_info_toc : Message
	{
		public int err_code = 0;
		public p_pet pet_info = null;
		public int op_type = 0;
		public m_rank_get_pet_info_toc() {
		}
		public override string getMethodName() {
			return "rank_get_pet_info";
		}
		public override string getClassName() {
			return "m_rank_get_pet_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_info", "p_pet", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
