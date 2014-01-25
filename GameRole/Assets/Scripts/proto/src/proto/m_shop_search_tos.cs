namespace proto {
	public class m_shop_search_tos : Message
	{
		public object[] search_goods_id;
		public int npc_id = 0;
		public m_shop_search_tos() {
		}
		public override string getMethodName() {
			return "shop_search";
		}
		public override string getClassName() {
			return "m_shop_search_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"search_goods_id", "array", "int"},new string[] {"npc_id", "int", "null"}};
		}
	}
}
