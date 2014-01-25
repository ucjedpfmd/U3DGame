namespace proto {
	public class m_rank_get_equip_info_toc : Message
	{
		public int err_code = 0;
		public p_goods equip_info = null;
		public m_rank_get_equip_info_toc() {
		}
		public override string getMethodName() {
			return "rank_get_equip_info";
		}
		public override string getClassName() {
			return "m_rank_get_equip_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"equip_info", "p_goods", "null"}};
		}
	}
}
