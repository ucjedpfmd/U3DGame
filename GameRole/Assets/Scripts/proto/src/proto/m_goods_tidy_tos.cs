namespace proto {
	public class m_goods_tidy_tos : Message
	{
		public int bagid = 0;
		public m_goods_tidy_tos() {
		}
		public override string getMethodName() {
			return "goods_tidy";
		}
		public override string getClassName() {
			return "m_goods_tidy_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bagid", "int", "null"}};
		}
	}
}
