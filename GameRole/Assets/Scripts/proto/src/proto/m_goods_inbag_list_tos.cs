namespace proto {
	public class m_goods_inbag_list_tos : Message
	{
		public int bagid = 0;
		public m_goods_inbag_list_tos() {
		}
		public override string getMethodName() {
			return "goods_inbag_list";
		}
		public override string getClassName() {
			return "m_goods_inbag_list_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bagid", "int", "null"}};
		}
	}
}
