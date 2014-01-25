namespace proto {
	public class m_goods_swap_tos : Message
	{
		public int id1 = 0;
		public int position2 = 0;
		public int bagid2 = 0;
		public m_goods_swap_tos() {
		}
		public override string getMethodName() {
			return "goods_swap";
		}
		public override string getClassName() {
			return "m_goods_swap_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id1", "int", "null"},new string[] {"position2", "int", "null"},new string[] {"bagid2", "int", "null"}};
		}
	}
}
