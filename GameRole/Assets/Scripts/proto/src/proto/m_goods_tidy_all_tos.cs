namespace proto {
	public class m_goods_tidy_all_tos : Message
	{
		public int type = 0;
		public m_goods_tidy_all_tos() {
		}
		public override string getMethodName() {
			return "goods_tidy_all";
		}
		public override string getClassName() {
			return "m_goods_tidy_all_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"type", "int", "null"}};
		}
	}
}
