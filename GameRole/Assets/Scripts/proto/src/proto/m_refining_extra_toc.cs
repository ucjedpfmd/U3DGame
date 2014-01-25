namespace proto {
	public class m_refining_extra_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public p_goods equip_goods = null;
		public int silver = 0;
		public int gold = 0;
		public m_refining_extra_toc() {
		}
		public override string getMethodName() {
			return "refining_extra";
		}
		public override string getClassName() {
			return "m_refining_extra_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"equip_goods", "p_goods", "null"},new string[] {"silver", "int", "null"},new string[] {"gold", "int", "null"}};
		}
	}
}
