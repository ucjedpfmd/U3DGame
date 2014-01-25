namespace proto {
	public class m_equip_info_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public double target_id = 0;
		public p_goods equip = null;
		public m_equip_info_toc() {
		}
		public override string getMethodName() {
			return "equip_info";
		}
		public override string getClassName() {
			return "m_equip_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"target_id", "double", "null"},new string[] {"equip", "p_goods", "null"}};
		}
	}
}
