namespace proto {
	public class m_goods_tidy_toc : Message
	{
		public int bagid = 0;
		public object[] goods;
		public m_goods_tidy_toc() {
		}
		public override string getMethodName() {
			return "goods_tidy";
		}
		public override string getClassName() {
			return "m_goods_tidy_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bagid", "int", "null"},new string[] {"goods", "array", "p_goods"}};
		}
	}
}
