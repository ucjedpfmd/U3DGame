namespace proto {
	public class m_shop_search_toc : Message
	{
		public object[] search_all_goods;
		public int npc_id = 0;
		public m_shop_search_toc() {
		}
		public override string getMethodName() {
			return "shop_search";
		}
		public override string getClassName() {
			return "m_shop_search_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"search_all_goods", "array", "p_shop_goods_info"},new string[] {"npc_id", "int", "null"}};
		}
	}
}
