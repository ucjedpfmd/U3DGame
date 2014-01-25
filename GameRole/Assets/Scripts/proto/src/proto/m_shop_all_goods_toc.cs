namespace proto {
	public class m_shop_all_goods_toc : Message
	{
		public int shop_id = 0;
		public object[] all_goods;
		public int npc_id = 0;
		public int buy_times = 0;
		public m_shop_all_goods_toc() {
		}
		public override string getMethodName() {
			return "shop_all_goods";
		}
		public override string getClassName() {
			return "m_shop_all_goods_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"shop_id", "int", "null"},new string[] {"all_goods", "array", "p_shop_goods_info"},new string[] {"npc_id", "int", "null"},new string[] {"buy_times", "int", "null"}};
		}
	}
}
