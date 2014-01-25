namespace proto {
	public class m_goods_divide_tos : Message
	{
		public int id = 0;
		public int num = 0;
		public int bagposition = 0;
		public int bagid = 0;
		public m_goods_divide_tos() {
		}
		public override string getMethodName() {
			return "goods_divide";
		}
		public override string getClassName() {
			return "m_goods_divide_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"num", "int", "null"},new string[] {"bagposition", "int", "null"},new string[] {"bagid", "int", "null"}};
		}
	}
}
