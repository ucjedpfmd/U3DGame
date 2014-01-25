namespace proto {
	public class m_rank_get_equip_info_tos : Message
	{
		public int rank_id = 0;
		public double role_id = 0;
		public double equip_id = 0;
		public m_rank_get_equip_info_tos() {
		}
		public override string getMethodName() {
			return "rank_get_equip_info";
		}
		public override string getClassName() {
			return "m_rank_get_equip_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"rank_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"equip_id", "double", "null"}};
		}
	}
}
