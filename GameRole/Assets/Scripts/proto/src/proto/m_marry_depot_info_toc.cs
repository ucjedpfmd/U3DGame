namespace proto {
	public class m_marry_depot_info_toc : Message
	{
		public int err_code = 0;
		public object[] couple_goods;
		public int op_type = 0;
		public m_marry_depot_info_toc() {
		}
		public override string getMethodName() {
			return "marry_depot_info";
		}
		public override string getClassName() {
			return "m_marry_depot_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"couple_goods", "array", "p_couple_goods"},new string[] {"op_type", "int", "null"}};
		}
	}
}
