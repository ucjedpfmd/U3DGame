namespace proto {
	public class m_chat_get_goods_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public int goods_id = 0;
		public p_goods goods_info = null;
		public m_chat_get_goods_toc() {
		}
		public override string getMethodName() {
			return "chat_get_goods";
		}
		public override string getClassName() {
			return "m_chat_get_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"goods_id", "int", "null"},new string[] {"goods_info", "p_goods", "null"}};
		}
	}
}
