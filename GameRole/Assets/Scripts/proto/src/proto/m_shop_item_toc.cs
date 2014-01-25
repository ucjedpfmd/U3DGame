namespace proto {
	public class m_shop_item_toc : Message
	{
		public int err_code = 0;
		public int shop_id = 0;
		public p_shop_goods_info goods = null;
		public m_shop_item_toc() {
		}
		public override string getMethodName() {
			return "shop_item";
		}
		public override string getClassName() {
			return "m_shop_item_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"shop_id", "int", "null"},new string[] {"goods", "p_shop_goods_info", "null"}};
		}
	}
}
