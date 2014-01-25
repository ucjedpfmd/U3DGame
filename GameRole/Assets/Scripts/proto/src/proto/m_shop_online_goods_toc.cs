namespace proto {
	public class m_shop_online_goods_toc : Message
	{
		public int shop_id = 0;
		public object[] all_goods;
		public m_shop_online_goods_toc() {
		}
		public override string getMethodName() {
			return "shop_online_goods";
		}
		public override string getClassName() {
			return "m_shop_online_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shop_id", "int", "null"},new string[] {"all_goods", "array", "p_shop_brief_goods_info"}};
		}
	}
}
