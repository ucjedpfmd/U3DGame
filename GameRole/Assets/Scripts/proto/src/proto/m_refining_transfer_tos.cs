namespace proto {
	public class m_refining_transfer_tos : Message
	{
		public int op_type = 0;
		public p_refining src_equip = null;
		public p_refining dst_equip = null;
		public m_refining_transfer_tos() {
		}
		public override string getMethodName() {
			return "refining_transfer";
		}
		public override string getClassName() {
			return "m_refining_transfer_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"src_equip", "p_refining", "null"},new string[] {"dst_equip", "p_refining", "null"}};
		}
	}
}
