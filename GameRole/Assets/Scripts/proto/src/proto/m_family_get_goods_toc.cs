namespace proto {
	public class m_family_get_goods_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_family_detail_item gain = null;
		public m_family_get_goods_toc() {
		}
		public override string getMethodName() {
			return "family_get_goods";
		}
		public override string getClassName() {
			return "m_family_get_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"gain", "p_family_detail_item", "null"}};
		}
	}
}
