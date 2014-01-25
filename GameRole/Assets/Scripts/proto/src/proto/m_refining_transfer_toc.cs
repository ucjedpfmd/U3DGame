namespace proto {
	public class m_refining_transfer_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public p_goods src_equip = null;
		public p_goods dst_equip = null;
		public int silver = 0;
		public m_refining_transfer_toc() {
		}
		public override string getMethodName() {
			return "refining_transfer";
		}
		public override string getClassName() {
			return "m_refining_transfer_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"src_equip", "p_goods", "null"},new string[] {"dst_equip", "p_goods", "null"},new string[] {"silver", "int", "null"}};
		}
	}
}
