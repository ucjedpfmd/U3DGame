namespace proto {
	public class m_goods_info_toc : Message
	{
		public int err_code = 0;
		public p_goods info = null;
		public int type = 0;
		public string reason = null;
		public int goods_id = 0;
		public m_goods_info_toc() {
		}
		public override string getMethodName() {
			return "goods_info";
		}
		public override string getClassName() {
			return "m_goods_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"info", "p_goods", "null"},new string[] {"type", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"goods_id", "int", "null"}};
		}
	}
}
