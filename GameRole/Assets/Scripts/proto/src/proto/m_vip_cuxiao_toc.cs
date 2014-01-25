namespace proto {
	public class m_vip_cuxiao_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public object[] cards;
		public m_vip_cuxiao_toc() {
		}
		public override string getMethodName() {
			return "vip_cuxiao";
		}
		public override string getClassName() {
			return "m_vip_cuxiao_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"cards", "array", "p_shop_goods_info"}};
		}
	}
}
