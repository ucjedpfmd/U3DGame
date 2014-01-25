namespace proto {
	public class m_letter_accept_goods_tos : Message
	{
		public object[] ids;
		public m_letter_accept_goods_tos() {
		}
		public override string getMethodName() {
			return "letter_accept_goods";
		}
		public override string getClassName() {
			return "m_letter_accept_goods_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"ids", "array", "int"}};
		}
	}
}
