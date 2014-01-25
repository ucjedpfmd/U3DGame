namespace proto {
	public class m_letter_accept_goods_toc : Message
	{
		public int err_code = 0;
		public object[] ids;
		public m_letter_accept_goods_toc() {
		}
		public override string getMethodName() {
			return "letter_accept_goods";
		}
		public override string getClassName() {
			return "m_letter_accept_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"ids", "array", "int"}};
		}
	}
}
