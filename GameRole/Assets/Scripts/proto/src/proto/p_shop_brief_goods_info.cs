namespace proto {
	public class p_shop_brief_goods_info : Message
	{
		public int goods_id = 0;
		public p_shop_price price = null;
		public p_shop_price vip_price = null;
		public p_shop_brief_goods_info() {
		}
		public override string getClassName() {
			return "p_shop_brief_goods_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"goods_id", "int", "null"},new string[] {"price", "p_shop_price", "null"},new string[] {"vip_price", "p_shop_price", "null"}};
		}
	}
}
