namespace proto {
	public class m_goods_divide_toc : Message
	{
		public int err_code = 0;
		public string reason = "";
		public p_goods goods1 = null;
		public p_goods goods2 = null;
		public m_goods_divide_toc() {
		}
		public override string getMethodName() {
			return "goods_divide";
		}
		public override string getClassName() {
			return "m_goods_divide_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"goods1", "p_goods", "null"},new string[] {"goods2", "p_goods", "null"}};
		}
	}
}
