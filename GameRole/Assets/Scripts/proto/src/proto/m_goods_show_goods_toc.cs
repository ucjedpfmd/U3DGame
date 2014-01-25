namespace proto {
	public class m_goods_show_goods_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public m_goods_show_goods_toc() {
		}
		public override string getMethodName() {
			return "goods_show_goods";
		}
		public override string getClassName() {
			return "m_goods_show_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"}};
		}
	}
}
